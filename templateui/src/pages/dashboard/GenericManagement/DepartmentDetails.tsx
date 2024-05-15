import React, { useState } from 'react'
import TableField from '../../../components/general/TableField';
import { useDetailJobTitle } from '../../../types/userDetails.type';

interface IProps{
   selectedDepartment:string;
}
const DepartmentDetails = ({selectedDepartment}:IProps) => {
  const [useDetails,setUserDetails] = useState<useDetailJobTitle[]>([]);

  const getUserDetailsJobTitle=(departmentName:string)=>async(){
    return departmentName;
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
      rows={useDetails}
      columns={columns}
      />
  )
}

export default DepartmentDetails