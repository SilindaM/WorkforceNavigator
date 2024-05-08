import { AxiosInstance, AxiosResponse } from "axios";

export interface IBaseRepository<T> {
  get(id: any): Promise<ApiResponse<T>>;
  getMany(): Promise<ApiResponse<T[]>>;
  create(id: any, item: T): Promise<ApiResponse<T>>;
  update(id: any, item: T): Promise<ApiResponse<T>>;
  delete(id: any): Promise<ApiResponse<T>>;
}

export class ApiResponse<T> {
  data?: T;
  succeeded?: boolean;
  errors: any;

  constructor(data?: T, succeeded?: boolean, errors?: any) {
    this.data = data;
    this.succeeded = succeeded;
    this.errors = errors;
  }
}

const transform = (response: AxiosResponse): Promise<ApiResponse<any>> => {
  return new Promise((resolve, reject) => {
    const result: ApiResponse<any> = {
      data: response.data,
      succeeded: response.status === 200,
      errors: response.data.errors,
    };
    resolve(result);
  });
};

export abstract class BaseRepository<T> implements IBaseRepository<T> {
  protected collection: string | undefined;
  protected httpClient: AxiosInstance;
  protected apiUrl: string;

  constructor(httpClient: AxiosInstance, apiUrl: string) {
    this.httpClient = httpClient;
    this.apiUrl = apiUrl;
  }

  protected createInstance(): AxiosInstance {
    return this.httpClient;
  }

  public async get(id: string): Promise<ApiResponse<T>> {
    const instance = this.createInstance();
    const result = await instance.get(`${this.apiUrl}/${this.collection}/${id}`).then(transform);
    return result as ApiResponse<T>;
  }
  
  public async getMany(): Promise<ApiResponse<T[]>> {
    const instance = this.createInstance();
    const result = await instance.get(`${this.apiUrl}/${this.collection}/`).then(transform);
    return result as ApiResponse<T[]>;
  }

  public async create(id: string, item: T): Promise<ApiResponse<T>> {
    const instance = this.createInstance();
    const result = await instance.post(`${this.apiUrl}/${this.collection}/`, item).then(transform);
    return result as ApiResponse<T>;
  }

  public async update(id: string, item: T): Promise<ApiResponse<T>> {
    const instance = this.createInstance();
    const result = await instance.put(`${this.apiUrl}/${this.collection}/${id}`, item).then(transform);
    return result as ApiResponse<T>;
  }

  public async delete(id: any): Promise<ApiResponse<T>> {
    const instance = this.createInstance();
    const result = await instance.delete(`${this.apiUrl}/${this.collection}/${id}`).then(transform);
    return result as ApiResponse<T>;
  }
}
