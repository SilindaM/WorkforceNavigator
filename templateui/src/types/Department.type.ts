export interface IUpdateDepartmentDto{
  DepartmentName:string;
  Description:string;
}
export interface IDepartmentDto extends IUpdateDepartmentDto{
  id:number;
}

interface IDepartmentTeamJobTitle {
  id:number;
  FirstName: string;
  LastName: string;
  Email: string;
  JobTitle: string;
  Team: string;
}