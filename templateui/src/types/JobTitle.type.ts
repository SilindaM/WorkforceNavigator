export interface IUpdateJobTitleDto{
    Title:string;
    Department:string;
    Seniority:string;
  }
  export interface IJobTitleDto extends IUpdateJobTitleDto{
    id:number;
  }