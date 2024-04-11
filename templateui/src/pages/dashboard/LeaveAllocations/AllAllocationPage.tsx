import React, { useEffect, useState } from 'react'
import { ILeaveAllocationDto } from '../../../types/leaveAllocation.type'
import axiosInstance from '../../../utils/axiosInstance';
import { ALL_LEAVE_ALLOCATIONS } from '../../../utils/globalConfig';
import toast from 'react-hot-toast';
import Spinner from '../../../components/general/Spinner';
import { Table } from 'react-bootstrap';
import 'bootstrap/dist/css/bootstrap.min.css';
const AllAllocationPage = () => {

  const [leaveAllocation,setLeaveAllocations] = useState<ILeaveAllocationDto[]>([]);
  const [loading,setLoading] = useState<boolean>(false);
 
  const getAllAllocations = async ()=>{
    try {
      setLoading(true);
      const response = await axiosInstance.get<ILeaveAllocationDto[]>(ALL_LEAVE_ALLOCATIONS)
      const {data} = response;
      setLeaveAllocations(data);
      setLoading(false);
    } catch (error) {
      toast.error("Error Occured")
      setLoading(false);
    }
  }
  useEffect(()=>{
    getAllAllocations();
  },[]);
  if(loading){
    return (
      <div className='w-full'>
        <Spinner/>
      </div>
    )
  }
  return (
    <div className="pageTemplate2">
    <Table striped="columns">
      <thead>
        <tr>
          <th>#</th>
          <th>First Name</th>
          <th>Last Name</th>
          <th>Username</th>
        </tr>
      </thead>
      <tbody>
        <tr>
          <td>1</td>
          <td>Mark</td>
          <td>Otto</td>
          <td>@mdo</td>
        </tr>
        <tr>
          <td>2</td>
          <td>Jacob</td>
          <td>Thornton</td>
          <td>@fat</td>
        </tr>
        <tr>
          <td>3</td>
          <td colSpan={2}>Larry the Bird</td>
          <td>@twitter</td>
        </tr>
      </tbody>
    </Table>
    </div>
  );
}
export default AllAllocationPage