import React from 'react';
import { Tab } from 'semantic-ui-react';
import UpcomingLeaveRequestPage from '../LeaveRequests/UpcomingLeaveRequestPage';
import ProcessLeaveRequestPage from '../LeaveRequests/ProcessLeaveRequestPage';
import useAuth from '../../../hooks/useAuth.hook';
import AllAllocationPage from '../LeaveAllocations/AllAllocationPage';
import MyLeaveAllocationsPage from '../LeaveAllocations/MyLeaveAllocationsPage';
import MyLeaveRequestPage from '../LeaveRequests/MyLeaveRequestPage';
import ClientsPage from './ClientsPage';
import ProjectsPage from './ProjectsPage';
import TeamsPage from './TeamsPage';
import DepartmentsPage from './DepartmentsPage';
import JobTitlesPage from './JobTitlesPage';

const GenericManagementPage = () => {
  const { user } = useAuth(); // Assuming you have a user object from your authentication context

  // Define panes excluding the "PROCESS REQUESTS" tab if the user is not an admin
  const panes = [
    {
      menuItem: 'CLIENTS',
      pane: { key: 'tab1', content: <ClientsPage /> },
    },
    {
      menuItem: 'PROJECTS',
      pane: { key: 'tab2', content: <ProjectsPage />, textAlign: 'center' },
    },
    {
      menuItem: 'TEAMS',
      pane: { key: 'tab3', content: <TeamsPage /> },
    },
    {
      menuItem: 'DEPARTMENTS',
      pane: { key: 'tab3', content: <DepartmentsPage /> },
    },
    {
      menuItem: 'JOBTITLES',
      pane: { key: 'tab3', content: <JobTitlesPage /> },
    },
  ];

  // If the user is an admin, include the "PROCESS REQUESTS AND ALL ALLOCATIONS" tab
  if (user && (user.roles.includes('ADMIN') || user.roles.includes('OWNER'))) {
    panes.push({
      menuItem: 'PROCESS REQUESTS',
      pane: { key: 'tab5', content: <ProcessLeaveRequestPage />, textAlign: 'center' },
    },
    {
      menuItem: 'LEAVE ALLOCATIONS',
      pane: { key: 'tab4', content: <AllAllocationPage />, textAlign: 'center' },
    },
  );
  }

  return (
    <div className='pageTemplate3 '>
      <Tab panes={panes} renderActiveOnly={false} />
    </div>
  );
};

export default GenericManagementPage;
