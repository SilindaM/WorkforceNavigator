import React from "react";
import {
 Grid,
 GridColumn,
 Segment,
 Container,
 Header,
 Button,
 Icon,
 GridRow,
} from "semantic-ui-react";

import UsersManagementPage from "../UserManagementPage";
import UserDetails from "./UserDetails";

const ManageUsersPage = () => {
 return (
    <Container fluid className="pageTemplate3">
      <Grid columns={2} >
        <GridColumn width={5}>
          <Segment raised>
            <Header as='h2' textAlign='center'>USERS</Header>
            <UsersManagementPage />
          </Segment>
        </GridColumn>

        <GridColumn width={11}>
          <Segment raised>
            <Header as='h2' textAlign='center'>USER DETAILS</Header>
            <UserDetails/>
          </Segment>
        </GridColumn>
      </Grid>
    </Container>
 );
};

export default ManageUsersPage;
