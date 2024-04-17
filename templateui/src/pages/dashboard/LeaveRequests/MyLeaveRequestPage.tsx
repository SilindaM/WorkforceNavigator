import React, { useEffect, useState } from "react";
import useAuth from "../../../hooks/useAuth.hook";
import { IMyLeaveRequestDto } from "../../../types/leaveRequest.type";
import axiosInstance from "../../../utils/axiosInstance";
import { MY_LEAVE_REQUESTS } from "../../../utils/globalConfig";
import toast from "react-hot-toast";
import Spinner from "../../../components/general/Spinner";
import { Button, TableCell, TableRow, TableBody, ButtonGroup, TextField } from "@mui/material";
import DeleteOutlineIcon from '@mui/icons-material/DeleteOutline';
import EditIcon from '@mui/icons-material/Edit';
import LeaveRequestModal from "./LeaveRequestModal";

const MyLeaveRequestPage = () => {
  const { user } = useAuth();
  const [requests, setLeaveRequests] = useState<IMyLeaveRequestDto[]>([]);
  const [loading, setLoading] = useState<boolean>(false);
  const [isModalOpen, setIsModalOpen] = useState<boolean>(false);
  const [selectedRequest, setSelectedRequest] = useState<IMyLeaveRequestDto | null>(null);

  const getMyLeaveRequests = async () => {
    try {
      setLoading(true);
      const response = await axiosInstance.get<IMyLeaveRequestDto[]>(
        MY_LEAVE_REQUESTS
      );
      const { data } = response;
      setLeaveRequests(data.map((request: IMyLeaveRequestDto) => ({ ...request, isEditing: false })));
      setLoading(false);
    } catch (error) {
      toast.error("Error Occurred");
      setLoading(false);
    }
  };

  useEffect(() => {
    getMyLeaveRequests();
  }, []);

  const handleEdit = (index: number) => {
    const updatedRequests = [...requests];
    updatedRequests[index].isEditing = true;
    setLeaveRequests(updatedRequests);
  };

  const handleSave = async (index: number) => {
    const updatedRequests = [...requests];
    updatedRequests[index].isEditing = false;
    try {
      setLoading(true);
      // Perform API call to save changes
      // For example:
      // await axiosInstance.put(`/leave-request/${updatedRequests[index].id}`, updatedRequests[index]);
      setLoading(false);
    } catch (error) {
      toast.error("Failed to save changes");
      setLoading(false);
    }
    setLeaveRequests(updatedRequests);
  };

 const handleInputChange = (event: React.ChangeEvent<HTMLInputElement>, index: number, field: keyof IMyLeaveRequestDto) => {
 const { value } = event.target;
 const updatedRequests = [...requests];
 // Use a type assertion to tell TypeScript that you know the type of the field
 (updatedRequests[index] as any)[field] = value;
 setLeaveRequests(updatedRequests);
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
    <React.Fragment>
      <table>
        <thead>
          <tr>
            <TableCell>Id</TableCell>
            <TableCell>Start Date</TableCell>
            <TableCell>End Date</TableCell>
            <TableCell>Requested Date</TableCell>
            <TableCell>Days</TableCell>
            <TableCell>Leave Name</TableCell>
            <TableCell>Status</TableCell>
            <TableCell>Comments</TableCell>
            <TableCell>Actions</TableCell>
          </tr>
        </thead>
        <TableBody>
          {requests.map((row, index) => (
            <TableRow key={row.id}>
              <TableCell>{row.id}</TableCell>
              <TableCell>
                {row.isEditing ? (
                  <TextField value={row.startDate} />
                ) : (
                  new Date(row.startDate).toLocaleDateString()
                )}
              </TableCell>
              <TableCell>
                {row.isEditing ? (
                  <TextField value={row.endDate}/>
                ) : (
                  new Date(row.endDate).toLocaleDateString()
                )}
              </TableCell>
              <TableCell>
                {row.isEditing ? (
                  <TextField value={row.requestedDate} />
                ) : (
                  new Date(row.requestedDate).toLocaleDateString()
                )}
              </TableCell>
              <TableCell>
                {row.isEditing ? (
                  <TextField value={String(row.numberOfDays)} />
                ) : (
                  row.numberOfDays
                )}
              </TableCell>
              <TableCell>
                {row.isEditing ? (
                  <TextField value={row.leaveName} />
                ) : (
                  row.leaveName
                )}
              </TableCell>
              <TableCell>{row.status}</TableCell>
              <TableCell>
                {row.isEditing ? (
                  <TextField value={row.comments} />
                ) : (
                  row.comments
                )}
              </TableCell>
              <TableCell>
                {row.isEditing ? (
                  <ButtonGroup>
                    <Button variant="outlined" onClick={() => handleSave(index)}>Save</Button>
                  </ButtonGroup>
                ) : (
                  <ButtonGroup>
                    <Button variant="outlined" color="warning" onClick={() => handleEdit(index)} startIcon={<EditIcon />}>Edit</Button>
                    <Button variant="outlined" color="error" startIcon={<DeleteOutlineIcon />} onClick={() => {}}>Delete</Button>
                  </ButtonGroup>
                )}
              </TableCell>
            </TableRow>
          ))}
        </TableBody>
      </table>
      {isModalOpen && selectedRequest && (
        <LeaveRequestModal
          isOpen={isModalOpen}
          closeModal={handleCloseModal}
          selectedRequest={selectedRequest}
        />
      )}
    </React.Fragment>
  );
};

export default MyLeaveRequestPage;
