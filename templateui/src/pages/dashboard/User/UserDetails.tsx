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
  Divider,
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
        <div className="ui form">
          <div className="two fields">
            <div className="field ">
              <>
                <label>First Name</label>
                <input type="text" value={userDetails?.firstName}></input>
              </>
            </div>
            <div className="field">
              <>
                <label>Last Name</label>
                <input type="text" value={userDetails?.lastName}></input>
              </>
            </div>
            <div className="field ">
              <>
                <label>Gender</label>
                <input type="text" value={userDetails?.gender} disabled></input>
              </>
            </div>
          </div>
          <div className="ui inverted divider"></div>
          <div className="two fields mt-2">
            <div className="field ">
              <>
                <label>User Name</label>
                <input type="text" value={userDetails?.username}></input>
              </>
            </div>
            <div className="field">
              <>
                <label>Email</label>
                <input type="text" value={userDetails?.email}></input>
              </>
            </div>
            <div className="field ">
              <>
                <label>Cellphone</label>
                <input type="text" value={userDetails?.email}></input>
              </>
            </div>
          </div>
          <div className="two fields"></div>
          <div className="ui inverted divider"></div>
          <div className="two fields mt-2">
            <div className="field ">
              <>
                <label>Career Manager</label>
                <input
                  placeholder="Career Manager"
                  type="text"
                  value={userDetails?.lineManager}
                ></input>
              </>
            </div>
            <div className="field">
              <>
                <label>Department</label>
                <input
                  placeholder="Last Name"
                  type="text"
                  value={userDetails?.department} disabled
                ></input>
              </>
            </div>
            <div className="field">
              <>
                <label>Level</label>
                <input
                  placeholder="First Name"
                  type="text"
                  value={userDetails?.seniority} disabled
                ></input>
              </>
            </div>
          </div>
          <div className="ui inverted divider"></div>
          <div className="two fields">
            <div className="field">
              <>
                <label>Assigned Roles</label>
                <input
                  placeholder="Last Name"
                  type="text"
                  value={userDetails?.roles} disabled
                ></input>
              </>
            </div>
            <div className="field">
              <>
                <label>Joining Date</label>
                <input
                  placeholder="Joining Date"
                  type="date"
                  value={
                    userDetails?.joiningDate
                      ? new Date(userDetails.joiningDate)
                          .toISOString()
                          .substring(0, 10)
                      : ""
                  } disabled
                ></input>
              </>
            </div>

            <div className="field">
              <>
                <label>Job Title</label>
                <input
                  placeholder="Last Name"
                  type="text"
                  value={userDetails?.jobTitle}
                ></input>
              </>
            </div>
          </div>
          <Button primary>Update User Details</Button>
        </div>
        <Divider horizontal>Upcoming Leaves</Divider>
        <Table size="small" bordered>
          <Table.Header>
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
            {leaves.filter((row) => row.status === Status.Approved).length >
            0 ? (
              // Render approved leave requests if there are any
              leaves
                .filter((row) => row.status === Status.Approved)
                .map((row) => (
                  <TableRow key={row.id}>
                    {/* Table cells */}
                    <Table.Cell>
                      {new Date(row.startDate).toLocaleDateString()}
                    </Table.Cell>
                    <Table.Cell>
                      {new Date(row.endDate).toLocaleDateString()}
                    </Table.Cell>
                    <Table.Cell>
                      {new Date(row.requestedDate).toLocaleDateString()}
                    </Table.Cell>
                    <Table.Cell>{row.numberOfDays}</Table.Cell>
                    <Table.Cell>{row.leaveName}</Table.Cell>
                    <Table.Cell>{row.status}</Table.Cell>
                  </TableRow>
                ))
            ) : (
              // Render "No upcoming leave requests" if there are no approved leaves
              <TableRow>
                <Table.Cell colSpan={6} textAlign="center">
                  No upcoming leave requests
                </Table.Cell>
              </TableRow>
            )}
          </TableBody>
        </Table>
      </Segment>
    </div>
  );
};

export default UserDetails;
