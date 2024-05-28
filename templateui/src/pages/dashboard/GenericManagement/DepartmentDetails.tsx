import React, { useEffect, useState } from 'react';
import TableField from '../../../components/general/TableField';
import { GenericCrudOperations } from '../../../components/general/GenericCrudOperations';

interface IProps {
  selectedDepartment: number | null; // Make selectedTimesheetId nullable
}

const DepartmentDetails = ({ selectedDepartment }: IProps) => {
  const [departmentUserJobTitleTeam, setTimesheetUserJobTitleTeam] = useState<[]>([]);
  const [loading, setLoading] = useState<boolean>(false);

  const columns = [
    { key: "firstName", label: "First Name" },
    { key: "lastName", label: "Last Name" },
    { key: "email", label: "Email" },
    { key: "jobTitle", label: "Job Title" },
    { key: "team", label: "Team" },
  ];

  useEffect(() => {
    
  }, [selectedDepartment ]); // useEffect dependency

  return (
    <TableField
      rows={departmentUserJobTitleTeam}
      columns={columns}
      showActions={false}
    />
  );
};

export default DepartmentDetails;