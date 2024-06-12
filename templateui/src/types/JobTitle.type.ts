import { Seniority } from "./auth.type";

export interface IUpdateJobTitleDto{
    title:string;
    department:string;
    description:string;
    seniority:Seniority;
  }
  
  export interface IJobTitleDto extends IUpdateJobTitleDto{
    id:number;
  }

  export interface IJobTitleUserDto{
    firstName : string;
    lastName :string;
    joiningDate:string;
  }
  export interface ICreateJobTitleDto{
    title:string;
    description:string;
    seniority:Seniority;
    departmentId:number;
  }