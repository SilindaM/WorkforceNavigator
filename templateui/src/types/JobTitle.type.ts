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
    DepartmentId:number;
    Description:string;
    Seniority:Seniority;
  }