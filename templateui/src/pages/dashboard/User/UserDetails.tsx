import React, { useEffect, useState } from "react";
import { Segment, Header, List, Icon, Grid } from "semantic-ui-react";
import { UserDetailsDto } from "../../../types/userDetails.type";
import axiosInstance from "../../../utils/axiosInstance";
import { USER_DETAILS_URL } from "../../../utils/globalConfig";
import toast from "react-hot-toast";

interface IProps{
  username:string;
}

const UserDetails = ({username}:IProps) => {
  const [loading,setLoading] = useState<boolean>(false);
  const [userDetails,setUserDetails] = useState<UserDetailsDto|null>(null);

const getUserDetails = async(username:string)=>{
  try {
    setLoading(true);
    console.log("get username " +username)
    const response = await axiosInstance.get<UserDetailsDto>(`${USER_DETAILS_URL}/${username}`);
    console.log(username);
    console.log("finished getting users");
    const {data} = response;
    console.log(data);
    setUserDetails(data);
    setLoading(false);
  } catch (error) {
      toast("failed to load user Details");
      setLoading(false);
  }
}
useEffect(()=>{
  getUserDetails(username);
  console.log("Effect " + username);
},[username])
    
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
                    <p><strong>First Name:</strong> John</p>
                    <p><strong>First Name:</strong> John</p>
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