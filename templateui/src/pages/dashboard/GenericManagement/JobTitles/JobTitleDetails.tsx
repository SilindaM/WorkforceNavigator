import React, { useEffect, useState } from 'react';
import { GenericCrudOperations } from '../../../../components/general/GenericCrudOperations';
import TableField from '../../../../components/general/TableField';
import { JOBTITLE_DETAILS } from '../../../../utils/globalConfig';
import { IJobTitleDto, IJobTitleUserDto } from '../../../../types/JobTitle.type';

interface IProps {
  selectedJobTitle: number;
}

const JobTitleDetails = ({ selectedJobTitle }: IProps) => {
  const [jobTitle, setJobTitle] = useState<IJobTitleUserDto[]>([]);
  const [loading, setLoading] = useState<boolean>(false);

  const getJobTitleDetails = async (id: number) => {
    await GenericCrudOperations.getDetails(JOBTITLE_DETAILS, id, setJobTitle, setLoading);
  };

  const columns = [
    { key: "firstName", label: "FirstName" },
    { key: "lastName", label: "LastName" },
    { key: "joiningDate", label: "JoiningDate" },
  ];

  useEffect(() => {
      getJobTitleDetails(selectedJobTitle);
  }, [selectedJobTitle]);

  return (
    <TableField
      rows={jobTitle}
      columns={columns}
      showActions={false}
    />
  );
};

export default JobTitleDetails;