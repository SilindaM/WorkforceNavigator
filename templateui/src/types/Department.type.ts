export interface IUpdateDepartmentDto{
  DepartmentName:string;
  Description:string;
}
export interface IDepartmentDto extends IUpdateDepartmentDto{
  id:number;
}