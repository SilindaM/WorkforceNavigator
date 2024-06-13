export interface IUpdateProjectDto {
    projectName: string;
    clientName: string;
    teamName:string;
    description:string;
    startDate: Date;
    endDate: Date;
}
export interface IProjectDto extends IUpdateProjectDto{
    id:number;
}