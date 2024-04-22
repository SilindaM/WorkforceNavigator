import React, { useEffect, useState } from 'react'
import { ILeaveAllocationDto } from '../../../types/leaveAllocation.type';
import { ILeaveRequestDto } from '../../../types/leaveRequest.type';
import axiosInstance from '../../../utils/axiosInstance';
import { ALL_LEAVE_REQUESTS, PROCESS_LEAVE_REQUEST_URL } from '../../../utils/globalConfig';
import toast from 'react-hot-toast';
import Spinner from '../../../components/general/Spinner';
import DeleteOutlineIcon from '@mui/icons-material/DeleteOutline';
import EditIcon from '@mui/icons-material/Edit';
import { Table, TableRow, TableCell, TableBody } from "semantic-ui-react";
import { Button, ButtonGroup } from '@mui/material';

interface LeaveStatus{
    id:number;
    status:string;
}

const AllLeaveRequestPage = () => {
    const [leaveRequest,setLeaveRequest] = useState<ILeaveRequestDto[]>([]);
    const [loading,setLoading] = useState<boolean>(false);
    const [selectRequest,setSelectedRequest] = useState<ILeaveRequestDto|null>(null);
    
    const getAllLeaveRequests = async()=>{
        try {
            setLoading(true);
            const response = await axiosInstance.get<ILeaveRequestDto[]>(ALL_LEAVE_REQUESTS);
            const {data} = response;
            setLeaveRequest(data);
            setLoading(false);
        } catch (error) {
          toast.error("Error Occured");
          setLoading(false);
        }
    }
    const processLeaveRequest = async (id: number, status: string) => {
      try {
          setLoading(true);
          const formData = new FormData();
          formData.append('status', status);
          const response = await axiosInstance.post(`${PROCESS_LEAVE_REQUEST_URL}?leaveRequestId=${id}`, formData, {
              headers: {
                  'Content-Type': 'multipart/form-data', // Adjust the content type if the server expects form data
              },
          });
          const { data } = response;
          console.log("test");
          setLeaveRequest(prevRequests => 
              prevRequests.map(request => request.id === id ? { ...request, status: data.status } : request)
          );
          toast.success("Successfully Processed Leave");
          setLoading(false);
      } catch (error) {
          console.error("Error processing leave request:", error);
          toast.error("Failed to process Leave");
          setLoading(false);
      }
  };
  
    const handleProcessing=(request:ILeaveRequestDto,action:string)=>{
        setSelectedRequest(request);
        processLeaveRequest(request.id,action);
    };
    useEffect(()=>{
        getAllLeaveRequests();
    },[])

    if(loading){
        return(
            <div className='w-full'><Spinner/></div>
        )
    }
    return (
        <>
          <div className='pageTemplate3 items-stretch'>
            <Table size="small" bordered>
              <Table.Header>
                <Table.Row>
                  <Table.HeaderCell>Id</Table.HeaderCell>
                  <Table.HeaderCell>FirstName</Table.HeaderCell>
                  <Table.HeaderCell>LastName</Table.HeaderCell>
                  <Table.HeaderCell>Leave Name</Table.HeaderCell>
                  <Table.HeaderCell>No Of Days</Table.HeaderCell>
                  <Table.HeaderCell>Start Date</Table.HeaderCell>
                  <Table.HeaderCell>End Date</Table.HeaderCell>
                  <Table.HeaderCell>Applied On</Table.HeaderCell>
                  <Table.HeaderCell>Status</Table.HeaderCell>
                  <Table.HeaderCell>Process</Table.HeaderCell>
                </Table.Row>
              </Table.Header>
              <tbody>
                {leaveRequest.map((item) => (
                  <tr key={item.id}>
                  <Table.Cell>{item.id}</Table.Cell>
                  <Table.Cell>{item.firstName}</Table.Cell>
                <Table.Cell>{item.lastName}</Table.Cell>
                 <Table.Cell>{item.leaveName}</Table.Cell>
                 <Table.Cell>{item.numberOfDays}</Table.Cell>
                <Table.Cell>{new Date(item.startDate).toLocaleDateString()}</Table.Cell>
                <Table.Cell>{new Date(item.endDate).toLocaleDateString()}</Table.Cell>
                <Table.Cell>{new Date(item.requestedDate).toLocaleDateString()}</Table.Cell>
                    <Table.Cell>{item.status}</Table.Cell>
                    <Table.Cell>
                  <ButtonGroup>
                    <Button
                      variant="outlined" color="warning"
                      sx={{ height: '30px' }} // Adjust the height as needed
                      style={{ fontSize: 'medium' }}
                      startIcon={<EditIcon />}
                      onClick={() => {handleProcessing(item,"Approved")}} // Pass the row data to the edit function
                    >
                      Accept
                    </Button>
                    <Button
                      variant="outlined" color="error"
                      sx={{ height: '30px' }} // Adjust the height as needed
                      style={{ fontSize: 'medium' }}
                      startIcon={<DeleteOutlineIcon />}
                      onClick={() => {handleProcessing(item,"Declined")}} // Implement delete functionality if needed
                    >
                      Decline
                    </Button>
                  </ButtonGroup>
                </Table.Cell>
                  </tr>
                ))}
              </tbody>
            </Table>
          </div>
        </>
      );
    };
    
export default AllLeaveRequestPage