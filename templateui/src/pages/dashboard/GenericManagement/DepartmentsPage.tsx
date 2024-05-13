import React, { useEffect, useState } from "react";
import { Button } from "@mui/material";
import AddIcon from "@mui/icons-material/Add";
import { useForm } from "react-hook-form";
import axiosInstance from "../../../utils/axiosInstance";
import { ALL_DEPARTMENTS, DELETE_DEPARTMENT_URL, NEW_DEPARTMENT_URL, UPDATE_DEPARTMENT_URL } from "../../../utils/globalConfig";
import toast from "react-hot-toast";
import { Container, Grid, GridColumn, Header, Segment } from "semantic-ui-react";
import TableField from "../../../components/general/TableField";
import GenericModal from "./GenericModal";
import { IDepartmentDto, IUpdateDepartmentDto } from "../../../types/Department.type";
import { GenericCrudOperations } from "../../../components/general/GenericCrudOperations";

const DepartmentsPage = () => {
  const { control } = useForm();
  const [loading, setLoading] = useState<boolean>(false);
  const [isOpen, setIsOpen] = useState(false);
  const [departments, setDepartments] = useState<IDepartmentDto[]>([]);
  const [selectedDepartment, setSelectedDepartment] = useState<IDepartmentDto | null>(null);
  const [departmentName, setDepartmentName] = useState<string>("");
  const [description, setDescription] = useState<string>("");

const handleOpenModal = ()=> {
  setIsOpen(true);
};

  const handleCloseModal = () => {
    setIsOpen(false);
  };

  const getDepartments = async () => {
   await GenericCrudOperations.getAll(ALL_DEPARTMENTS,setDepartments,setLoading);
  };

  const AddDepartment = async (newData: IDepartmentDto) => {
      await GenericCrudOperations.add(NEW_DEPARTMENT_URL, newData, setLoading);
      getDepartments();
  };
  
  const UpdateDepartment = async (id: number, updatedData: IUpdateDepartmentDto) => {
    await GenericCrudOperations.update(UPDATE_DEPARTMENT_URL,id,updatedData,setLoading);
  };

  const DeleteDepartment = async(id:number)=>{
    await GenericCrudOperations.remove(DELETE_DEPARTMENT_URL,id,setLoading);
  }

  const handleEdit = (updatedData: IDepartmentDto) => {
    console.log("Editing:", updatedData); // Check if this logs the correct data
    setSelectedDepartment(updatedData);
    handleOpenModal();
  };
  
  
  const handleDelete = (id: number) => {
    console.log("Get Id",id);
    DeleteDepartment(id)
    console.log("Received ",id);
  };

  const handleSubmit = () => {
    handleCloseModal();
  };

  useEffect(() => { 
    getDepartments();
  }, []);

  const columns = [{ key: 'departmentName', label: "Department Name" },{key: 'description', label: "Descriptuion" }];

  return (
    <div>
      <Container fluid className="pageTemplate3">
        <Grid columns={2}>
          <GridColumn width={8}>
            <Segment raised>
              <Header as="h2" textAlign="center">
                <Button
                  variant="outlined"
                  sx={{ height: "40px" }}
                  startIcon={<AddIcon />}
                  onClick={() => handleOpenModal()}
                >
                  New Leave Request
                </Button>
              </Header>
              <TableField
                rows={departments}
                columns={columns}
                onEdit={handleEdit}
                onDelete={handleDelete}
              />
            </Segment>
          </GridColumn>

          <GridColumn width={8}>
            <Segment raised>
              <Header as="h2" textAlign="center">
                DETAILS
              </Header>
            </Segment>
          </GridColumn>
        </Grid>
      </Container>

<GenericModal
  isOpen={isOpen}
  closeModal={handleCloseModal}
  title="Add Client"
  formFields={[
    {
      controlId: "departmentName",
      label: "Department Name",
      value: departmentName,
      onChange: setDepartmentName,
    },
    {
      controlId: "Description",
      label: "Description",
      value: description,
      onChange: setDescription,
    },
  ]}
  handleSubmit={handleSubmit}
  mode={selectedDepartment ? "edit" : "add"}
  selectedEntity={selectedDepartment} // Check if selectedDepartment is correctly passed here
  updateEntity={UpdateDepartment}
  addEntity={AddDepartment}
/>



    </div>
  );
};

export default DepartmentsPage;