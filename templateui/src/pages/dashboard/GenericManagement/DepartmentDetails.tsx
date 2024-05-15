import React, { useState } from 'react'
import TableField from '../../../components/general/TableField';
import { GenericCrudOperations } from '../../../components/general/GenericCrudOperations';
import { DepartmentUserJobTitleTeam } from '../../../types/userDetails.type';
import { DEPARTMENT_JOBTITLE_TEAM } from '../../../utils/globalConfig';

interface IProps{
   selectedDepartment:number;
}
const DepartmentDetails = ({selectedDepartment}:IProps) => {
  const [useDetails,setUserDetails] = useState<number>();
  const [departmentUserJobTitleTeam,setDepartmentUserJobTitleTeam] = useState<DepartmentUserJobTitleTeam[]>([]);
  const [loading,setLoading] = useState<boolean>(false);

  const getUserDetailsJobTitle=(departmentId:number)=>async()=>{
    await GenericCrudOperations.getDetails(DEPARTMENT_JOBTITLE_TEAM,departmentId,setDepartmentUserJobTitleTeam ,setLoading);
  }

   const columns = [
    { key: "firstName", label: "firstName" },
    { key: "lastName", label: "lastName" },
    { key: "email", label: "email" },
    { key: "jobTitle", label: "jobTitle" },
    { key: "team", label: "team" },
  ];

  return (
    <TableField
      rows={departmentUserJobTitleTeam}
      columns={columns}
      />
  )
}

export default DepartmentDetails