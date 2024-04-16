import React from 'react'
import { Container, Grid, GridColumn, Segment, Header } from 'semantic-ui-react'
import InboxPage from '../Messages/InboxPage'
import SendMessagePage from '../Messages/SendMessagePage'
import UserDetails from '../User/UserDetails'
import MyLeaveAllocationsPage from './MyLeaveAllocationsPage'

const ManageLeavesPage = () => {
  return (    <Container fluid className="pageTemplate3">
  <Grid columns={2}>
    <GridColumn>
      <Segment raised>
        <Header as='h2' textAlign='center'>My Allocated Leave</Header>
        <MyLeaveAllocationsPage />
      </Segment>
    </GridColumn>

    <GridColumn>
      <Segment raised>
        <Header as='h2' textAlign='center'>My Leave Requests</Header>
        <SendMessagePage/>
      </Segment>
    </GridColumn>
  </Grid>
</Container>
  )
}

export default ManageLeavesPage