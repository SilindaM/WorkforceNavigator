type WeekDay = "Monday" | "Tuesday" | "Wednesday" | "Thursday" | "Friday";
function toMidnight(date: Date): Date {
  return new Date(date.getFullYear(), date.getMonth(), date.getDate());
}
interface TimesheetDto{
    date: string;
    dayName: WeekDay;
    totalhours: number;
    projectNames: Set<string>;
}

interface TimesheetDetailsDto{
  description:string;
  timeSpent:number;
  projectName:string;
}