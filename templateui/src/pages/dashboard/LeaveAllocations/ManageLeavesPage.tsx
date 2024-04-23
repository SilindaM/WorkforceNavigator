import React from 'react'
import { TabPane, ListItem, List, Label, Tab } from 'semantic-ui-react'
import InboxPage from '../Messages/InboxPage'
import MyLeaveAllocationsPage from './MyLeaveAllocationsPage'
import MyLeaveRequestPage from '../LeaveRequests/MyLeaveRequestPage'
import AllAllocationPage from './AllAllocationPage'
import AllLeaveRequestPage from '../LeaveRequests/AllLeaveRequestPage'
import ProcessLeaveRequestPage from '../LeaveRequests/ProcessLeaveRequestPage'

const panes = [
  {
    menuItem: 'MY LEAVE ALLOCATIONS',
    pane: { key: 'tab1', content: <MyLeaveAllocationsPage/>},
  },
  {
    menuItem: 'MY LEAVE REQUESTS',
    pane: {
      key: 'tab2',
      content: <MyLeaveRequestPage/>,
      textAlign: 'center',
    },
  },
  {
    menuItem: 'ALL LEAVE REQUESTS',
    pane: {
      key: 'tab3',
      content: <AllLeaveRequestPage/>
    },
  },
  {
    menuItem: 'LEAVE ALLOCATIONS',
    pane: {
      key: 'tab4',
      content: <AllAllocationPage/>,
      textAlign: 'center',
    },
  },
  {
    menuItem: 'PROCESS REQUESTS',
    pane: {
      key: 'tab5',
      content: <ProcessLeaveRequestPage/>,
      textAlign: 'center',
    },
  },
]

const ManageLeavesPage = () => (
  <div className='pageTemplate3 '>
    
  <Tab panes={panes} renderActiveOnly={false} />
  </div>
)

export default ManageLeavesPage