import { Seniority } from "./auth.type";


export interface IUpdateJobTitleDto{
    Title:string;
    Department:string;
    Description:string;
    Seniority:Seniority;
  }
  export interface IJobTitleDto extends IUpdateJobTitleDto{
    id:number;
  }

  export interface ICreateJobTitleDto{
    Title:string;
    Description:string;
    Seniority:Seniority;
    DepartmentId:number;
  }