import React from "react";
import { Segment, Header, List, Icon, Grid } from "semantic-ui-react";

const UserDetails = () => {
    
 return (
    <div style={{ padding: "20px" }}>
      <Segment>
        <List relaxed>
          <List.Item>
            <Segment>
              <Grid columns={2}>
                <Grid.Column width={3}>
                 <Icon name="user circle" size="big" />
                </Grid.Column>
                <Grid.Column width={13}>
                 <Header as="h3">Personal Information</Header>
                 <List.Description>
                    <p><strong>First Name:</strong> John</p>
                    <p><strong>Last Name:</strong> Doe</p>
                    <p><strong>Gender:</strong> Male</p>
                 </List.Description>
                </Grid.Column>
              </Grid>
            </Segment>
          </List.Item>
          <List.Item>
            <Segment>
              <Grid columns={2}>
                <Grid.Column width={3}>
                 <Icon name="briefcase" size="big" />
                </Grid.Column>
                <Grid.Column width={13}>
                 <Header as="h3">Employment Details</Header>
                 <List.Description>
                    <p><strong>Job Title:</strong> Software Engineer</p>
                    <p><strong>Salary:</strong> $100,000</p>
                    <p><strong>Line Manager:</strong> Jane Smith</p>
                 </List.Description>
                </Grid.Column>
              </Grid>
            </Segment>
          </List.Item>
          <List.Item>
            <Segment>
              <Grid columns={2}>
                <Grid.Column width={3}>
                 <Icon name="info circle" size="big" />
                </Grid.Column>
                <Grid.Column width={13}>
                 <Header as="h3">Additional Information</Header>
                 <List.Description>
                    <p><strong>Department:</strong> Engineering</p>
                    <p><strong>Car Registration:</strong> ABC123</p>
                    <p><strong>Next of Kin:</strong> Mary Doe</p>
                 </List.Description>
                </Grid.Column>
              </Grid>
            </Segment>
          </List.Item>
          <List.Item>
            <Segment>
              <Grid columns={2}>
                <Grid.Column width={3}>
                 <Icon name="calendar alternate outline" size="big" />
                </Grid.Column>
                <Grid.Column width={13}>
                 <Header as="h3">Upcoming Leaves</Header>
                 <List.Description>
                    <p>No upcoming leaves</p>
                 </List.Description>
                </Grid.Column>
              </Grid>
            </Segment>
          </List.Item>
          <List.Item>
            <Segment>
              <Grid columns={2}>
                <Grid.Column width={3}>
                 <Icon name="calendar check outline" size="big" />
                </Grid.Column>
                <Grid.Column width={13}>
                 <Header as="h3">Leave Allocations</Header>
                 <List.Description>
                    <p>No leave allocations</p>
                 </List.Description>
                </Grid.Column>
              </Grid>
            </Segment>
          </List.Item>
        </List>
      </Segment>
    </div>
 );
};

export default UserDetails;
