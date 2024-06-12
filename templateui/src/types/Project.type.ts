export interface IUpdateProjectDto {
    projectName: string;
    clientName: string;
    startDate: Date;
    endDate: Date;
}
export interface IProjectDto extends IUpdateProjectDto{
    id:number;
}

export interface IProjectDetails{
    
}