import React, { useEffect, useState } from 'react';
import { GenericCrudOperations } from '../../../../components/general/GenericCrudOperations';
import TableField from '../../../../components/general/TableField';

interface IProps {
  selectedProject: number;
}

const ProjectDetails = ({ selectedProject }: IProps) => {
  const [projectUserJobTitleTeam, setProjectUserJobTitleTeam] = useState<IProjectTeamJobTitle[]>([]);
  const [loading, setLoading] = useState<boolean>(false);

  const getProjectDetails = async (id: number) => {
    await GenericCrudOperations.getDetails(PROJECT_JOBTITLE_TEAM, id, setProjectUserJobTitleTeam, setLoading);
  };

  const columns = [
    { key: "firstName", label: "First Name" },
    { key: "lastName", label: "Last Name" },
    { key: "email", label: "Email" },
    { key: "jobTitle", label: "Job Title" },
    { key: "team", label: "Team" },
  ];

  useEffect(() => {
    getProjectDetails(selectedProject);
  }, [selectedProject]);

  return (
    <TableField
      rows={projectUserJobTitleTeam}
      columns={columns}
      showActions={false}
    />
  );
};

export default ProjectDetails;
