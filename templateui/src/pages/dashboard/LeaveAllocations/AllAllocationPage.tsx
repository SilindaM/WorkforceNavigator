import React, { useEffect, useState } from 'react'
import { ILeaveAllocationDto } from '../../../types/leaveAllocation.type'
import axiosInstance from '../../../utils/axiosInstance';
import { ALL_LEAVE_ALLOCATIONS } from '../../../utils/globalConfig';
import toast from 'react-hot-toast';
import Spinner from '../../../components/general/Spinner';
import 'bootstrap/dist/css/bootstrap.min.css';
import { Table } from 'semantic-ui-react';
import { MdInput, MdOutput } from 'react-icons/md';
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
    <div>
      <div className='pageTemplate3 items-stretch'>
        <Table celled>
          <Table.Header>
            <Table.Row>
              <Table.HeaderCell>No Of Days</Table.HeaderCell>
              <Table.HeaderCell>Leave Name</Table.HeaderCell>
            </Table.Row>
          </Table.Header>
          <tbody>
            {leaveAllocation.map((item) => (
              <tr key={item.Username}>
                 <Table.Cell>{item.NumberOfDays}</Table.Cell>
               <Table.Cell>{item.LeaveName}</Table.Cell>
                <Table.Cell>{item.NumberOfDays}</Table.Cell>
                <Table.Cell>{item.LeaveName}</Table.Cell>
                <Table.Cell>{item.Username}</Table.Cell>
              </tr>
            ))}
          </tbody>
        </Table>
      </div>
    </div>
  );
};

export default AllAllocationPage