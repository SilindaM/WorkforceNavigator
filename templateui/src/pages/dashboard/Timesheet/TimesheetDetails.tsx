import React, { useEffect, useState } from 'react';
import TableField from '../../../components/general/TableField';
import { GenericCrudOperations } from '../../../components/general/GenericCrudOperations';
import { DepartmentUserJobTitleTeam } from '../../../types/userDetails.type';
import { DEPARTMENT_JOBTITLE_TEAM } from '../../../utils/globalConfig';

interface IProps {
  selectedDepartmentId: number | null; // Make selectedDepartmentId nullable
}

const TimesheetDetails = ({ selectedDepartmentId }: IProps) => {
  const [departmentUserJobTitleTeam, setDepartmentUserJobTitleTeam] = useState<DepartmentUserJobTitleTeam[]>([]);
  const [loading, setLoading] = useState<boolean>(false);

  const getUserDetailsJobTitle = async (departmentId: number) => {
    console.log("Testing ", departmentId);
    await GenericCrudOperations.getDetails(DEPARTMENT_JOBTITLE_TEAM, departmentId, setDepartmentUserJobTitleTeam, setLoading);
  };

  const columns = [
    { key: "firstName", label: "First Name" },
    { key: "lastName", label: "Last Name" },
    { key: "email", label: "Email" },
    { key: "jobTitle", label: "Job Title" },
    { key: "team", label: "Team" },
  ];

  useEffect(() => {
    if (selectedDepartmentId !== null) { // Check if selectedDepartmentId is not null
      getUserDetailsJobTitle(selectedDepartmentId);
    }
  }, [selectedDepartmentId]); // useEffect dependency

  return (
    <TableField
      rows={departmentUserJobTitleTeam}
      columns={columns}
      showActions={false}
    />
  );
};

export default TimesheetDetails;