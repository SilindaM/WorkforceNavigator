type WeekDay = "Monday" | "Tuesday" | "Wednesday" | "Thursday" | "Friday";

interface TimesheetDto{
    date: String;
    dayName: WeekDay;
    totalhours: number;
    projectNames: Set<string>;
}

interface TimesheetDetailsDto{
  description:string;
  timeSpent:number;
  projectName:string;
}