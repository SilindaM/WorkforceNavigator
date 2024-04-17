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