import React, { useEffect, useState } from 'react';
import TableField from '../../../components/general/TableField';
import { GenericCrudOperations } from '../../../components/general/GenericCrudOperations';
import { DepartmentUserJobTitleTeam } from '../../../types/userDetails.type';
import { DEPARTMENT_JOBTITLE_TEAM, TIMESHEET_DAY_DETAILS } from '../../../utils/globalConfig';

interface IProps {
  selectedTimesheet: Date ;
}

const TimesheetDetails = ({ selectedTimesheet }: IProps) => {
  const [timesheetDetail, setTimesheetDetail] = useState<[]>([]);
  const [loading, setLoading] = useState<boolean>(false);

  
  const getDayTimesheet = async (date: Date) => {
    setLoading(true);
    await GenericCrudOperations.getDetailed(TIMESHEET_DAY_DETAILS, {date}, setTimesheetDetail, setLoading);
    setLoading(false);
  };

  const columns = [
    { key: "description", label: "Description" },
    { key: "timeSpent", label: "Time Spent" },
    { key: "projectName", label: "Project Name" },
  ];

  useEffect(() => {
    getDayTimesheet(selectedTimesheet),
    setTimesheetDetail
  }, []); 

  return (
    <TableField
      rows={timesheetDetail}
      columns={columns}
      showActions={false}
    />
  );
};

export default TimesheetDetails;