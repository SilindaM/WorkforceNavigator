type WeekDay = "Monday" | "Tuesday" | "Wednesday" | "Thursday" | "Friday";

interface TimesheetDto{
    date: Date;
    dayName: WeekDay;
    totalhours: number;
    projectNames: Set<string>;
}

interface TimesheetDetailsDto{
  description:string;
  timeSpent:number;
  projectName:string;
}