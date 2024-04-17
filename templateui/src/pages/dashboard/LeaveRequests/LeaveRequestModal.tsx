import React, { useState } from "react";
import Button from "react-bootstrap/Button";
import Form from "react-bootstrap/Form";
import Modal from "react-bootstrap/Modal";
import { IMyLeaveRequestDto } from "../../../types/leaveRequest.type";
import axiosInstance from "../../../utils/axiosInstance";
import { MY_LEAVE_ALLOCATIONS } from "../../../utils/globalConfig";
import toast from "react-hot-toast";

interface IProps {
  isOpen: boolean;
  closeModal: () => void; // Corrected to a function type
  selectedRequest: IMyLeaveRequestDto;
  //leaveNames: string[];
}

const LeaveRequestModal = ({ isOpen, closeModal, selectedRequest }: IProps) => {
  const [loading, setLoading] = useState<boolean>(false);
  const [leaveAllocations, setLeaveAllocations] = useState<string[]>([]);
  // Use the isOpen prop to control the visibility of the modal
  //get Leave Allocated to the loggedIn User
  const myLeaveAllocations = async () => {
    try {
      setLoading(true);
      const response = await axiosInstance.get<string[]>(MY_LEAVE_ALLOCATIONS);
      const { data } = response;
      setLeaveAllocations(data);
      setLoading(false);
    } catch (error) {
      toast.error("Failed To Fetch Your Allocated Leaves");
      setLoading(false);
    }
  };
  const handleClose = () => {
    closeModal(); // Call the function passed through props to close the modal
  };
  return (
    <>
      <Modal show={isOpen} onHide={handleClose} className="custom-modal">
        <Modal.Header closeButton>
          <Modal.Title>Edit Leave Request</Modal.Title>
        </Modal.Header>
        <Modal.Body>
          <Form>
            {" "}
            <Form.Group className="mb-3" controlId="formStartDate">
              <Form.Label>Start Date</Form.Label>
              <Form.Control
                type="text"
                value={new Date(selectedRequest.startDate).toLocaleDateString()}
              />
            </Form.Group>
            <Form.Group className="mb-3" controlId="formEndDate">
              <Form.Label>End Date</Form.Label>
              <Form.Control
                type="text"
                value={new Date(selectedRequest.endDate).toLocaleDateString()}
              />
            </Form.Group>
            <Form.Group className="mb-3" controlId="formRequestedDate">
              <Form.Label>Requested Date</Form.Label>
              <Form.Control
                type="text"
                value={new Date(
                  selectedRequest.requestedDate
                ).toLocaleDateString()}
              />
            </Form.Group>
            <Form.Group className="mb-3" controlId="formLeaveName">
              <Form.Label>Leave Name</Form.Label>
              <Form.Control type="text" value={selectedRequest.leaveName} />
            </Form.Group>
            <Form.Group className="mb-3" controlId="formComments">
              <Form.Label>Comments</Form.Label>
              <Form.Control
                as="textarea"
                rows={3}
                value={selectedRequest.comments}
              />
            </Form.Group>
            <Form.Group className="mb-3" controlId="formNumberOfDays">
              <Form.Label>Number of Days</Form.Label>
              <Form.Control
                type="text"
                value={selectedRequest.numberOfDays}
                disabled
              />
            </Form.Group>
            <Form.Group className="mb-3" controlId="formStatus">
              <Form.Label>Status</Form.Label>
              <Form.Control
                type="text"
                value={selectedRequest.status}
                disabled
              />
            </Form.Group>
          </Form>
        </Modal.Body>
        <Modal.Footer>
          <Button variant="secondary" onClick={handleClose}>
            Close
          </Button>
          <Button variant="primary" onClick={handleClose}>
            Save Changes
          </Button>
        </Modal.Footer>
      </Modal>
    </>
  );
};

export default LeaveRequestModal;