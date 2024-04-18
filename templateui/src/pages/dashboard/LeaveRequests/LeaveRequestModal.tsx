import React, { useEffect, useState } from "react";
import Button from "react-bootstrap/Button";
import Form from "react-bootstrap/Form";
import Modal from "react-bootstrap/Modal";
import { IMyLeaveRequestDto, IUpdateLeaveRequestDto } from "../../../types/leaveRequest.type";
import axiosInstance from "../../../utils/axiosInstance";
import { MY_LEAVE_ALLOCATIONS } from "../../../utils/globalConfig";
import toast from "react-hot-toast";
import DatePicker from "react-datepicker";
import "react-datepicker/dist/react-datepicker.css";

interface IProps {
  isOpen: boolean;
  closeModal: () => void;
  selectedRequest: IMyLeaveRequestDto;
  updateLeaveRequest: (id: number, updatedData: IUpdateLeaveRequestDto) => Promise<void>; 
}
const LeaveRequestModal = ({ isOpen, closeModal, selectedRequest,updateLeaveRequest  }: IProps) => {
  
  const [loading, setLoading] = useState<boolean>(false);
  const [leaveAllocations, setLeaveAllocations] = useState< IMyLeaveRequestDto[]>([]);
  const [startDate, setStartDate] = useState<Date>( new Date(selectedRequest.startDate));
  const [endDate, setEndDate] = useState<Date>( new Date(selectedRequest.endDate));
  const [leaveName, setLeaveName] = useState<string>(selectedRequest.leaveName);
  const [comments, setComments] = useState<string>(selectedRequest.comments);
  const [numberOfDays, setNumberOfDays] = useState<number>( selectedRequest.numberOfDays);
  const [status, setStatus] = useState<string>(selectedRequest.status);

  const myLeaveAllocations = async () => {
    try {
      setLoading(true);
      const response = await axiosInstance.get<IMyLeaveRequestDto[]>(
        MY_LEAVE_ALLOCATIONS
      );
      const { data } = response;
      setLeaveAllocations(data);
      console.log("My Data " + data);
      setLoading(false);
    } catch (error) {
      toast.error("Failed To Fetch Your Allocated Leaves");
      setLoading(false);
    }
  };

  const handleClose = () => {
    closeModal();
  };

  const handleSave = () => {
    const timeDifference = new Date(endDate).getTime() - new Date(startDate).getTime();
  
    const numberOfDays = Math.ceil(timeDifference / (1000 * 60 * 60 * 24));
  
    const updateData = {
      id: selectedRequest.id,
      startDate,
      endDate,
      comments: selectedRequest.comments,
      numberOfDays: numberOfDays // Assign the calculated numberOfDays
    };
    updateLeaveRequest(selectedRequest.id, updateData);
  };
  
  
  useEffect(() => {
    myLeaveAllocations();
  }, []);
  return (
    <>
      <Modal show={isOpen} onHide={handleClose} className="custom-modal">
        <Modal.Header closeButton>
          <Modal.Title>Edit Leave Request</Modal.Title>
        </Modal.Header>
        <Modal.Body>
          <Form>
            <Form.Group className="mb-3" controlId="formStartDate">
              <Form.Label>Start Date</Form.Label>
              <DatePicker
                selected={startDate}
                onChange={(date: Date) => setStartDate(date)}
                dateFormat="MM/dd/yyyy"
              />
            </Form.Group>
            <Form.Group className="mb-3" controlId="formEndDate">
              <Form.Label>End Date</Form.Label>
              <DatePicker
                selected={endDate}
                onChange={(date: Date) => setEndDate(date)}
                dateFormat="MM/dd/yyyy"
              />
            </Form.Group>

            <Form.Group className="mb-3" controlId="formLeaveName">
              <Form.Label>Leave Name</Form.Label>
              <Form.Select
                value={leaveName}
                onChange={(e) => setLeaveName(e.target.value)}
              >
                {leaveAllocations.map((allocation, index) => (
                  <option key={index} value={allocation.id}>
                    {allocation.leaveName}
                  </option>
                ))}
              </Form.Select>
            </Form.Group>
            <Form.Group className="mb-3" controlId="formComments">
              <Form.Label>Comments</Form.Label>
              <Form.Control
                as="textarea"
                rows={3}
                value={comments}
                onChange={(e) => setComments(e.target.value)}
              />
            </Form.Group>
            <Form.Group className="mb-3" controlId="formNumberOfDays">
              <Form.Label>Number of Days</Form.Label>
              <Form.Control type="text" value={numberOfDays} disabled />
            </Form.Group>
            <Form.Group className="mb-3" controlId="formStatus">
              <Form.Label>Status</Form.Label>
              <Form.Control type="text" value={status} disabled />
            </Form.Group>
          </Form>
        </Modal.Body>
        <Modal.Footer>
          <Button variant="secondary" onClick={handleClose}>
            Close
          </Button>
          <Button variant="primary" onClick={handleSave}>
            Save Changes
          </Button>
        </Modal.Footer>
      </Modal>
    </>
  );
};

export default LeaveRequestModal;
