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
  Form,
  Dropdown,
} from "semantic-ui-react";
import {
  DepartmentDto,
  UserDetailsDto,
  UserDetailsUpdateDto,
} from "../../../types/userDetails.type";
import axiosInstance from "../../../utils/axiosInstance";
import {
  ALL_DEPARTMENTS,
  ALL_JOBTITLES,
  MY_LEAVE_REQUESTS,
  UPDATE_USER_DETAILS,
  USER_DETAILS_URL,
} from "../../../utils/globalConfig";
import toast from "react-hot-toast";
import { IMyLeaveAllocationDto } from "../../../types/leaveAllocation.type";
import { IMyLeaveRequestDto, Status } from "../../../types/leaveRequest.type";
import { RolesEnum, Seniority } from "../../../types/auth.type";
import { GenericCrudOperations } from "../../../components/general/GenericCrudOperations";
import { IJobTitleDto } from "../../../types/JobTitle.type";

interface IProps {
  username: string;
}

const UserDetails = ({ username }: IProps) => {
  const [loading, setLoading] = useState<boolean>(false);
  const [userDetails, setUserDetails] = useState<UserDetailsDto>();
  const [leaves, setLeaves] = useState<IMyLeaveRequestDto[]>([]);
  const [firstName, setFirstName] = useState<string>("");
  const [lastName, setLastName] = useState<string>("");
  const [email, setEmail] = useState<string>("");
  const [gender, setGender] = useState<string>("");
  const [seniority, setSeniority] = useState<string>("");
  const [cellphone, setCellphone] = useState<number>(0);
  const [salary, setSalary] = useState<number>(0);
  const [lineManager, setLineManager] = useState<string>("");
  const [jobTitle, setJobtitle] = useState<string>("");
  const [roles, setRoles] = useState<RolesEnum[]>([]);
  const [jobTitles, setJobTitles] = useState<IJobTitleDto[]>([]);

  const UpdateUserDetails = async (updateUsername: string, userDetail: UserDetailsUpdateDto) => {
    await GenericCrudOperations.update(UPDATE_USER_DETAILS, updateUsername, userDetail, setLoading);
  };

  const getJobTitles = async () => {
    await GenericCrudOperations.getAll(ALL_JOBTITLES, setJobTitles, setLoading);
  };

  const getMyLeaves = async () => {
    await GenericCrudOperations.getAll(MY_LEAVE_REQUESTS, setLeaves, setLoading);
  };

  const getUserDetails = async (username: string) => {
    await GenericCrudOperations.getDetails(USER_DETAILS_URL, username, setUserDetails, setLoading);
  };

  useEffect(() => {
    getUserDetails(username);
    getMyLeaves();
    getJobTitles();
  }, [username]);

  useEffect(() => {
    if (userDetails) {
      setFirstName(userDetails.firstName || "");
      setLastName(userDetails.lastName || "");
      setEmail(userDetails.email || "");
      setGender(userDetails.gender || "");
      setLineManager(userDetails.lineManager || "");
      setJobtitle(userDetails.jobTitle || "");
      setCellphone(userDetails.cellphone || 0);
      setSalary(userDetails.salary || 0);
    }
  }, [userDetails]);

  const Gender = [
    { key: "male", text: "Male", value: "male" },
    { key: "female", text: "Female", value: "female" },
  ];
  const Seniority= [
    { key: "junior", text: "Junior", value: "junior" },
    { key: "mid", text: "Mid", value: "mid" },
    { key: "senior", text: "Senior", value: "senior" },
    { key: "lead", text: "Lead", value: "lead" },
];


  const handleInputChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = event.target;
    switch (name) {
      case "firstName":
        setFirstName(value);
        break;
      case "lastName":
        setLastName(value);
        break;
      case "email":
        setEmail(value);
        break;
      case "gender":
        setGender(value);
        break;
      case "cellphone":
        setCellphone(Number(value));
        break;
      case "lineManager":
        setLineManager(value);
        break;
      case "jobTitle":
        setJobtitle(value);
        break;
        case "salary":
              setSalary(Number(value));
              break;
              case "seniority":
                    setSeniority(value);
                    break;
      default:
        break;
    }
  };

  const handleUpdate = () => {
    const updateData: UserDetailsUpdateDto = {
      email,
      firstName,
      lastName,
      gender,
      jobTitle,
      salary,
      cellphone,
      seniority
    };
    console.log(username, "And ", updateData); // Log the data before sending
    UpdateUserDetails(username, updateData);
  };

  return (
    <div style={{ padding: "20px" }}>
      <Segment>
        <Form>
          <Form.Group widths="equal">
            <Form.Field>
              <label>First Name</label>
              <input
                type="text"
                name="firstName"
                value={firstName}
                onChange={handleInputChange}
              />
            </Form.Field>
            <Form.Field>
              <label>Last Name</label>
              <input
                type="text"
                name="lastName"
                value={lastName}
                onChange={handleInputChange}
              />
            </Form.Field>
            <Form.Field>
              <label>Gender</label>
              <Dropdown
                selection
                options={Gender}
                value={gender}
                onChange={(e, { value }) => setGender(value as string)}
              />
            </Form.Field>
         
          </Form.Group>
          <Form.Group widths="equal">
            <Form.Field>
              <label>User Name</label>
              <input type="text" value={userDetails?.username} disabled />
            </Form.Field>
            <Form.Field>
              <label>Line Manager</label>
              <input type="text" value={lineManager} disabled />
            </Form.Field>
            <Form.Field>
              <label>Email</label>
              <input
                type="email"
                name="email"
                value={email}
                onChange={handleInputChange}
              />
            </Form.Field>
          </Form.Group>
          <Form.Group widths="equal">
            <Form.Field>
                <label>Job Title</label>
                <Dropdown
                  selection
                  options={jobTitles.map((title) => ({
                    key: title.id,
                    text: title.title,
                    value: title.title,
                  }))}
                  value={jobTitle}
                  onChange={(e, { value }) => setJobtitle(value as string)}
                />
              </Form.Field>
              <Form.Field>
              <label>Cellphone</label>
              <input
                type="cellphone"
                name="cellphone"
                value={cellphone}
                onChange={handleInputChange}
              />
            </Form.Field>
            <Form.Field>
              <label>Seniority</label>
              <Dropdown
                selection
                options={Seniority}
                value={seniority}
                onChange={(e, { value }) => setSeniority(value as string)}
              />
            </Form.Field>
          </Form.Group>
          <Form.Group widths="equal">
             <Form.Field>
              <label>Salary</label>
              <input
                type="text"
                name="salary"
                value={salary}
                onChange={handleInputChange}
              />
            </Form.Field>
            <Form.Field>
              <label>Assigned Roles</label>
              <input
                placeholder="Assigned Roles"
                type="text"
                value={roles.join(", ")}
                disabled
              />
            </Form.Field>
            <Form.Field>
              <label>Joining Date</label>
              <input
                placeholder="Joining Date"
                type="date"
                value={
                  userDetails?.joiningDate
                    ? new Date(userDetails.joiningDate).toISOString().substring(0, 10)
                    : ""
                }
                disabled
              />
            </Form.Field>
            <Form.Field>
              <label>Job Title</label>
              <Dropdown
                selection
                options={jobTitles.map((title) => ({
                  key: title.id,
                  text: title.title,
                  value: title.title,
                }))}
                value={jobTitle}
                onChange={(e, { value }) => setJobtitle(value as string)}
              />
            </Form.Field>
          </Form.Group>
          <Button primary type="submit" onClick={handleUpdate}>
            Update User Details
          </Button>
        </Form>
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
            {leaves.filter((row) => row.status === Status.Approved).length > 0 ? (
              leaves
                .filter((row) => row.status === Status.Approved)
                .map((row) => (
                  <TableRow key={row.id}>
                    <Table.Cell>{new Date(row.startDate).toLocaleDateString()}</Table.Cell>
                    <Table.Cell>{new Date(row.endDate).toLocaleDateString()}</Table.Cell>
                    <Table.Cell>{new Date(row.requestedDate).toLocaleDateString()}</Table.Cell>
                    <Table.Cell>{row.numberOfDays}</Table.Cell>
                    <Table.Cell>{row.leaveName}</Table.Cell>
                    <Table.Cell>{row.status}</Table.Cell>
                  </TableRow>
                ))
            ) : (
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