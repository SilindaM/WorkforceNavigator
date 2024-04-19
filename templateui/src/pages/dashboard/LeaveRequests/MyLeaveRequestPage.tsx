// MyLeaveRequestPage.js
import React, { useEffect, useState } from "react";
import useAuth from "../../../hooks/useAuth.hook";
import { IAddLeaveRequestDto, IMyLeaveRequestDto, IUpdateLeaveRequestDto } from "../../../types/leaveRequest.type";
import axiosInstance from "../../../utils/axiosInstance";
import toast from "react-hot-toast";
import Spinner from "../../../components/general/Spinner";
import { Button, TableHead } from "@mui/material";
import { Table, TableRow, TableCell, TableBody, ButtonGroup } from "semantic-ui-react";
import DeleteOutlineIcon from '@mui/icons-material/DeleteOutline';
import EditIcon from '@mui/icons-material/Edit';
import AddIcon from '@mui/icons-material/Add';
import LeaveRequestModal from "./LeaveRequestModal";
import { MY_LEAVE_REQUESTS, NEW_LEAVE_REQUEST_URL, UPDATE_LEAVE_REQUEST_URL } from "../../../utils/globalConfig";

const MyLeaveRequestPage = () => {
  const { user } = useAuth();
  const [requests, setLeaveRequests] = useState<IMyLeaveRequestDto[]>([]);
  const [loading, setLoading] = useState<boolean>(false);
  const [isModalOpen, setIsModalOpen] = useState<boolean>(false);
  const [selectedRequest, setSelectedRequest] = useState<IMyLeaveRequestDto | null>(null);

  const getMyLeaveRequests = async () => {
    try {
      setLoading(true);
      const response = await axiosInstance.get<IMyLeaveRequestDto[]>(MY_LEAVE_REQUESTS);
      const { data } = response;
      setLeaveRequests(data);
      setLoading(false);
    } catch (error) {
      toast.error("Error Occured");
      setLoading(false);
    }
  };

  const AddNewLeaveRequest = async (newData: IAddLeaveRequestDto) => {
    try {
      setLoading(true); 
      const requestData: IAddLeaveRequestDto = {
        ...newData,// Assuming leave type ID is stored in leaveTypeId
      };
      const response = await axiosInstance.post(NEW_LEAVE_REQUEST_URL, requestData);
      const { data } = response;
      // Update the state with the new request
      setLeaveRequests(prevRequests => [...prevRequests, data]);
      toast.success("Leave Request Added Successfully");
      setLoading(false);
    } catch (error) {
      console.error("Error adding new leave request:", error);
      toast.error("Failed To Add Leave");
      setLoading(false);
    }
  };

  const UpdateMyLeaveRequest = async (id: number, updatedData: IUpdateLeaveRequestDto) => {
    try {
      setLoading(true);
      const response = await axiosInstance.post(`${UPDATE_LEAVE_REQUEST_URL}?leaveRequestId=${id}`, updatedData);
      const {data} = response;
      setLeaveRequests(prevRequests => 
        prevRequests.map(request => 
          request.id === id ? { ...request, startDate: updatedData.startDate, endDate: updatedData.endDate } : request
        )
      );
      toast.success("Leave Request Updated Successfully");
      setLoading(false);
    } catch (error) {
      console.error("Error updating leave request:", error);
      toast.error("Failed To Update Leave");
      setLoading(false);
    }
  };

  useEffect(() => {
    getMyLeaveRequests();
  }, []);

  const handleEdit = (request: IMyLeaveRequestDto) => {
    setSelectedRequest(request);
    setIsModalOpen(true);
  };

  const handleAdd = () => {
    console.log("Adding new leave request");
    setIsModalOpen(true);
    setSelectedRequest(null); // Clear any previously selected request
  };

  const handleCloseModal = () => {
    setIsModalOpen(false);
  };

  if (loading) {
    return (
      <div className="w-full">
        <Spinner />
      </div>
    );
  }

  return (
    <>
      <Button
        variant="outlined"
        sx={{ height: "40px" }} // Adjust the height as needed
        startIcon={<AddIcon />}
        onClick={handleAdd}
      >
        New Leave Request
      </Button>
      <React.Fragment>
        <Table size="small" bordered>
          <TableHead>
            <TableRow>
              {/* Header cells */}
              <TableCell>Id</TableCell>
              <TableCell>Start Date</TableCell>
              <TableCell>End Date</TableCell>
              <TableCell>Requested Date</TableCell>
              <TableCell>Days</TableCell>
              <TableCell>Leave Name</TableCell>
              <TableCell>Status</TableCell>
              <TableCell>Comments</TableCell>
              <TableCell>Actions</TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {requests.map((row) => (
              <TableRow key={row.id}>
                {/* Table cells */}
                <TableCell>{row.id}</TableCell>
                <TableCell>{new Date(row.startDate).toLocaleDateString()}</TableCell>
                <TableCell>{new Date(row.endDate).toLocaleDateString()}</TableCell>
                <TableCell>{new Date(row.requestedDate).toLocaleDateString()}</TableCell>
                <TableCell>{row.numberOfDays}</TableCell>
                <TableCell>{row.leaveName}</TableCell>
                <TableCell>{row.status}</TableCell>
                <TableCell>{row.comments}</TableCell>
                <TableCell>
                  <ButtonGroup>
                    <Button
                      variant="outlined" color="warning"
                      sx={{ height: '30px' }} // Adjust the height as needed
                      style={{ fontSize: 'medium' }}
                      startIcon={<EditIcon />}
                      onClick={() => handleEdit(row)} // Pass the row data to the edit function
                    >
                      Edit
                    </Button>
                    <Button
                      variant="outlined" color="error"
                      sx={{ height: '30px' }} // Adjust the height as needed
                      style={{ fontSize: 'medium' }}
                      startIcon={<DeleteOutlineIcon />}
                      onClick={() => {}} // Implement delete functionality if needed
                    >
                      Delete
                    </Button>
                  </ButtonGroup>
                </TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
        {isModalOpen && (
          <LeaveRequestModal
            isOpen={isModalOpen}
            closeModal={handleCloseModal}
            selectedRequest={selectedRequest}
            updateLeaveRequest={UpdateMyLeaveRequest}
            addLeaveRequest={AddNewLeaveRequest}
            mode={selectedRequest ? "edit" : "add"}
          />
        )}
      </React.Fragment>
    </>
  );
};

export default MyLeaveRequestPage;
