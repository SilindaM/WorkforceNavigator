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
  MY_LEAVE_REQUESTS,
  UPCOMNG_LEAVE_REQUESTS,
  UPDATE_USER_DETAILS,
  USER_DETAILS_URL,
} from "../../../utils/globalConfig";
import toast from "react-hot-toast";
import { IMyLeaveAllocationDto } from "../../../types/leaveAllocation.type";
import { IMyLeaveRequestDto, Status } from "../../../types/leaveRequest.type";
import { RolesEnum } from "../../../types/auth.type";
import { GenericCrudOperations } from "../../../components/general/GenericCrudOperations";

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
  const [cellphone, setCellphone] = useState<number>(0);
  const [lineManager, setLineManager] = useState<string>("");
  const [jobTitle, setJobtitle] = useState<string>("");
  const [departmentName, setdepartmentName] = useState<string>("");
  const [roles, setRoles] = useState<RolesEnum[]>([]);
  const [department, setDepartments] = useState<DepartmentDto[]>([]);

  const UpdateUserDetails = async (updateUsername: string,userDetail: UserDetailsUpdateDto) => {
    await GenericCrudOperations.update(UPDATE_USER_DETAILS,updateUsername,userDetails,setLoading);
};

  const getAllDepartments= async()=>{
   await GenericCrudOperations.getAll(ALL_DEPARTMENTS,setDepartments,setLoading);
  };
  
  const getMyLeaves = async () => {
    await GenericCrudOperations.getAll(MY_LEAVE_REQUESTS,setLeaves,setLoading);
  };

  const getUserDetails = async (username: string) => {
    console.log(username);
    await GenericCrudOperations.getDetails(USER_DETAILS_URL, username, setUserDetails, setLoading);
  };

  useEffect(() => {
    getUserDetails(username);
    getMyLeaves();
    getAllDepartments();
    setUserDetails(undefined);

    console.log("Effect " + username);
  }, [username]);

  const Gender = [
    { key: "male", text: "Male", value: "male" },
    { key: "female", text: "Female", value: "female" },
  ];
  const Depar = [department];

  const selectedGender = userDetails
    ? Gender.find((option) => option.value === userDetails.gender)
    : null;
    
  const selectedDepartment = userDetails
    ? department.find(
        (option) => option.departmentName === userDetails.department
      )
    : null;

  const handleInputChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    event.preventDefault();
    const { name, value } = event.target;
    setUserDetails(
      (
        prevDetails = {
          id: "", // Provide default values for all properties
          firstName: "",
          lastName: "",
          email: "",
          username: "",
          roles: [],
          gender: "",
          jobTitle: "",
          salary: 0,
          lineManager: "",
          department: "",
          seniority: "",
          joiningDate: new Date(),
        }
      ) => ({
        ...prevDetails,
        [name]: value,
      })
    );
  };
  const handleUpdate = () => {
    const updateData: UserDetailsUpdateDto = {
      email,
      firstName,
      lastName,
      gender,
      jobTitle,
      lineManager,
      roles,
      departmentName,
    };
    UpdateUserDetails(username, updateData);
  };
  return (
    <div style={{ padding: "20px" }}>
      <Segment>
        <Form>
          <Form.Group widths="equal">
            <Form.Field>
              <label>First Name</label>
              <input type="text" defaultValue={userDetails?.firstName} />
            </Form.Field>
            <Form.Field>
              <label>Last Name</label>
              <input type="text" defaultValue={userDetails?.lastName} />
            </Form.Field>{" "}
            <Form.Field>
              <label>Gender</label>
              <input type="text" defaultValue={userDetails?.gender} />
              <Dropdown
                selection
                options={Gender}
                defaultValue={userDetails?.gender}
              />
            </Form.Field>
          </Form.Group>
          <Form.Group widths="equal">
            <Form.Field>
              <label>User Name</label>
              <input type="text" value={userDetails?.username} disabled />
            </Form.Field>
            <Form.Field>
              <label>Email</label>
              <input type="email" defaultValue={userDetails?.email} />
            </Form.Field>
            <Form.Field>
              <label>Cellphone</label>
              <input type="text" defaultValue={userDetails?.email} />
            </Form.Field>
          </Form.Group>
          <Form.Group widths="equal">
            <Form.Field>
              <label>Career Manager</label>
              <input
                placeholder="Career Manager"
                type="text"
                defaultValue={userDetails?.lineManager}
              />
            </Form.Field>
            <Form.Field>
              <label>Department</label>
              <input type="text" defaultValue={userDetails?.department} />
              <Dropdown
                selection
                options={department.map((dept) => ({
                  key: dept.id,
                  text: dept.departmentName,
                  value: dept.departmentName,
                }))} // Map department names as options
                defaultValue={userDetails?.department} // Use selectedGender value if available
              />
            </Form.Field>

            <Form.Field>
              <label>Level</label>
              <input
                placeholder="Level"
                type="text"
                value={userDetails?.seniority}
                disabled
              />
            </Form.Field>
          </Form.Group>
          <Form.Group widths="equal">
            <Form.Field>
              <label>Assigned Roles</label>
              <input
                placeholder="Assigned Roles"
                type="text"
                defaultValue={userDetails?.roles || ""}
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
                    ? new Date(userDetails.joiningDate)
                        .toISOString()
                        .substring(0, 10)
                    : ""
                }
                disabled
              />
            </Form.Field>
            <Form.Field>
              <label>Job Title</label>
              <input type="text" defaultValue={userDetails?.jobTitle} />
              <Dropdown
                selection
                options={Gender}
                defaultValue={
                  selectedGender ? selectedGender.value : userDetails?.jobTitle
                } // Use selectedGender value if available
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