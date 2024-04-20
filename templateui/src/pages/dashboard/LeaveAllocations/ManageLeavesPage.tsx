import React from 'react'
import { TabPane, ListItem, List, Label, Tab } from 'semantic-ui-react'
import InboxPage from '../Messages/InboxPage'
import MyLeaveAllocationsPage from './MyLeaveAllocationsPage'
import MyLeaveRequestPage from '../LeaveRequests/MyLeaveRequestPage'

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
      content: (
        <div>
          This tab contains a <Label>JSX</Label> element
        </div>
      ),
    },
  },
  {
    menuItem: 'LEAVE ALLOCATIONS',
    pane: (
      <TabPane key='tab4'>
        <p>This tab has complex content</p>

        <List>
          <ListItem>Apples</ListItem>
          <ListItem>Pears</ListItem>
          <ListItem>Oranges</ListItem>
        </List>
      </TabPane>
    ),
  },
]

const ManageLeavesPage = () => (
  <div className='pageTemplate3 '>
    
  <Tab panes={panes} renderActiveOnly={false} />
  </div>
)

export default ManageLeavesPage