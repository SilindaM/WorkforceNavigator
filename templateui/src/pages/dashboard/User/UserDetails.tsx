import React, { useEffect, useState } from "react";
import {
  Segment,
  Header,
  List,
  Icon,
  Grid,
  Button,
  ButtonGroup,
  Table,
  TableBody,
  TableRow,
} from "semantic-ui-react";
import { UserDetailsDto } from "../../../types/userDetails.type";
import axiosInstance from "../../../utils/axiosInstance";
import {
  MY_LEAVE_REQUESTS,
  UPCOMNG_LEAVE_REQUESTS,
  USER_DETAILS_URL,
} from "../../../utils/globalConfig";
import toast from "react-hot-toast";
import { IMyLeaveAllocationDto } from "../../../types/leaveAllocation.type";
import { IMyLeaveRequestDto, Status } from "../../../types/leaveRequest.type";

interface IProps {
  username: string;
}

const UserDetails = ({ username }: IProps) => {
  const [loading, setLoading] = useState<boolean>(false);
  const [userDetails, setUserDetails] = useState<UserDetailsDto | null>(null);
  const [leaves, setLeaves] = useState<IMyLeaveRequestDto[]>([]);

  const getMyLeaves = async () => {
    try {
      setLoading(true);
      const response = await axiosInstance.get<IMyLeaveRequestDto[]>(
        MY_LEAVE_REQUESTS
      );
      const { data } = response;
      setLeaves(data);
      setLoading(false);
    } catch (error) {
      toast.error("Failed To Fetch Your Leaves");
      setLoading(false);
    }
  };

  const getUserDetails = async (username: string) => {
    try {
      setLoading(true);
      const response = await axiosInstance.get<UserDetailsDto>(
        `${USER_DETAILS_URL}/${username}`
      );
      const { data } = response;
      console.log(data);
      setUserDetails(data);
      setLoading(false);
    } catch (error) {
      toast("failed to load user Details");
      setLoading(false);
    }
  };
  useEffect(() => {
    getUserDetails(username);
    getMyLeaves();
    console.log("Effect " + username);
  }, [username]);

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
                    <p>
                      <strong>First Name:</strong> {userDetails?.firstName}
                    </p>
                    <p>
                      <strong>Last Name:</strong> {userDetails?.lastName}
                    </p>
                    <p>
                      <strong>Email :</strong> {userDetails?.email}
                    </p>
                    <p>
                      <strong>Gender:</strong> {userDetails?.gender}
                    </p>
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
                    <p>
                      <strong>Job Title:</strong> {userDetails?.jobTitle}
                    </p>
                    <p>
                      <strong>Salary:</strong> {userDetails?.salary}
                    </p>
                    <p>
                      <strong>Line Manager:</strong> {userDetails?.lineManager}
                    </p>
                    <p>
                      <strong>Department:</strong> {userDetails?.department}
                    </p>
                    <p>
                      <strong>Job Level:</strong> {userDetails?.seniority}
                    </p>
                  </List.Description>
                </Grid.Column>
              </Grid>
            </Segment>
          </List.Item>

          <Table size="small" bordered>
            <Table.Header>
              <Table.Header>UPCOMING LEAVES</Table.Header>
              <TableRow>
                <Table.HeaderCell>Start Date</Table.HeaderCell>
                <Table.HeaderCell>End Date</Table.HeaderCell>
                <Table.HeaderCell>Requested Date</Table.HeaderCell>
                <Table.HeaderCell>Number Of Days</Table.HeaderCell>
                <Table.HeaderCell>Leave Name</Table.HeaderCell>
                <Table.HeaderCell>Status</Table.HeaderCell>
              </TableRow>
            </Table.Header>
            <TableBody>
  {leaves.filter(row => row.status === Status.Approved).length > 0 ? (
    // Render approved leave requests if there are any
    leaves.filter(row => row.status === Status.Approved).map(row => (
      <TableRow key={row.id}>
        {/* Table cells */}
        <Table.Cell>{new Date(row.startDate).toLocaleDateString()}</Table.Cell>
        <Table.Cell>{new Date(row.endDate).toLocaleDateString()}</Table.Cell>
        <Table.Cell>{new Date(row.requestedDate).toLocaleDateString()}</Table.Cell>
        <Table.Cell>{row.numberOfDays}</Table.Cell>
        <Table.Cell>{row.leaveName}</Table.Cell>
        <Table.Cell>{row.status}</Table.Cell>
      </TableRow>
    ))
  ) : (
    // Render "No upcoming leave requests" if there are no approved leaves
    <TableRow>
      <Table.Cell colSpan={6} textAlign="center">No upcoming leave requests</Table.Cell>
    </TableRow>
  )}
</TableBody>


          </Table>
        </List>
      </Segment>
    </div>
  );
};

export default UserDetails;
