export interface IMyLeaveRequestDto{
    id:number;
    numberOfDays: number;
    username: string;
    leaveName: string;
    comments: string;
    startDate: Date;
    endDate: Date;
    requestedDate:Date;
    status : Status;
    isEditing?:boolean;
}
export enum Status {
    Approved = 'Approved',
    Declined = 'Declined',
    Pending = 'Pending',
  }

  export interface IUpdateLeaveRequestDto{
    startDate:Date;
    endDate:Date;
    comments?:string;
    numberOfDays: number;
  }