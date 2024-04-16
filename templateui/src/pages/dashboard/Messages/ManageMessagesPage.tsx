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
import InboxPage from "./InboxPage";
import SendMessagePage from "./SendMessagePage";

const ManageMessagesPage = () => {
 return (
    <Container fluid className="mt-4">
      <Grid columns={2}>
        <GridColumn>
          <Segment raised>
            <Header as='h2' textAlign='center'>Inbox</Header>
            <InboxPage />
          </Segment>
        </GridColumn>

        <GridColumn>
          <Segment raised>
            <Header as='h2' textAlign='center'>Send Message</Header>
            <SendMessagePage/>
          </Segment>
          <Segment raised>
            <Header as='h2' textAlign='center'>Send Message</Header>
            <SendMessagePage/>
            <SendMessagePage/>
          </Segment>
        </GridColumn>
      </Grid>
    </Container>
 );
};

export default ManageMessagesPage;
