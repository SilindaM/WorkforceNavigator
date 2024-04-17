import React from 'react';
import { Container, Grid, GridColumn, Segment, Header } from 'semantic-ui-react';
import MyLeaveAllocationsPage from './MyLeaveAllocationsPage';
import MyLeaveRequestPage from '../LeaveRequests/MyLeaveRequestPage';

const ManageLeavesPage = () => {
  return (
    <Container fluid className="pageTemplate3">
      <Grid columns={2}>
        <GridColumn width={6}>
          <Segment raised>
            <Header as='h2' textAlign='center'>My Allocated Leave</Header>
            <MyLeaveAllocationsPage />
          </Segment>
        </GridColumn>

        <GridColumn width={10}>
          <Segment raised>
            <Header as='h2' textAlign='center'>My Leave Requests</Header>
            <MyLeaveRequestPage/>
          </Segment>
        </GridColumn>
      </Grid>
    </Container>
  );
};

export default ManageLeavesPage;
