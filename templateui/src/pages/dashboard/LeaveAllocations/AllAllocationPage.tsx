import React, { useEffect, useState } from 'react'
import { ILeaveAllocationDto } from '../../../types/leaveAllocation.type'
import axiosInstance from '../../../utils/axiosInstance';
import { ALL_LEAVE_ALLOCATIONS } from '../../../utils/globalConfig';
import toast from 'react-hot-toast';
import Spinner from '../../../components/general/Spinner';

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
    <div>AllAllocationPage</div>
  )
}
export default AllAllocationPage