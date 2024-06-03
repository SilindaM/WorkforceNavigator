export interface IUpdateDepartmentDto{
  DepartmentName:string;
  Description:string;
}
export interface IDepartmentDto extends IUpdateDepartmentDto{
  id:number;
}

export interface IDepartmentTeamJobTitle {
  FirstName: string;
  LastName: string;
  Email: string;
  JobTitle: string;
  Team: string;
}