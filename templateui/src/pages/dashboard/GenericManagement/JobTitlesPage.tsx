import React, { useEffect, useState } from "react";
import { Button } from "@mui/material";
import AddIcon from "@mui/icons-material/Add";
import { useForm } from "react-hook-form";
import axiosInstance from "../../../utils/axiosInstance";
import toast from "react-hot-toast";
import { Container, Grid, GridColumn, Header, Segment } from "semantic-ui-react";
import TableField from "../../../components/general/TableField";
import GenericModal from "./GenericModal";
import { GenericCrudOperations } from "../../../components/general/GenericCrudOperations";
import { IJobTitleDto, IUpdateJobTitleDto } from "../../../types/JobTitle.type";
import { ALL_JOB_TITLES, DELETE_JOBTITLE_URL, NEW_JOBTITLE_URL, UPDATE_JOBTITLE_URL } from "../../../utils/globalConfig";

const JobTitlesPage = () => {
  const { control } = useForm();
  const [loading, setLoading] = useState<boolean>(false);
  const [isOpen, setIsOpen] = useState(false);
  const [JobTitles, setJobTitles] = useState<IJobTitleDto[]>([]);
  const [selectedJobTitle, setSelectedJobTitle] = useState<IJobTitleDto | null>(null);
  const [JobTitle, setJobTitle] = useState<string>("");
  const [Department, setDepartment] = useState<string>("");
  const [Seniority, setSeniority] = useState<string>("");

const handleOpenModal = ()=> {
  setIsOpen(true);
};

  const handleCloseModal = () => {
    setIsOpen(false);
  };

  const getJobTitles = async () => {
   await GenericCrudOperations.getAll(ALL_JOB_TITLES,setJobTitles,setLoading);
  };

  const AddJobTitle = async (newData: IJobTitleDto) => {
      await GenericCrudOperations.add(NEW_JOBTITLE_URL, newData, setLoading);
      getJobTitles();
  };
  
  const UpdateJobTitle = async (id: number, updatedData: IUpdateJobTitleDto) => {
    await GenericCrudOperations.update(UPDATE_JOBTITLE_URL,id,updatedData,setLoading);
  };

  const DeleteJobTitle = async(id:number)=>{
    await GenericCrudOperations.remove(DELETE_JOBTITLE_URL,id,setLoading);
  }

  const handleEdit = (updatedData: IJobTitleDto) => {
    console.log("Editing:", updatedData); // Check if this logs the correct data
    setSelectedJobTitle(updatedData);
    handleOpenModal();
  };
  
  
  const handleDelete = (id: number) => {
    console.log("Get Id",id);
    DeleteJobTitle(id)
    console.log("Received ",id);
  };

  const handleSubmit = () => {
    handleCloseModal();
  };

  useEffect(() => { 
    getJobTitles();
  }, []);

  const columns = [{ key: 'JobTitle', label: "JobTitle" },{key: 'Department', label: "Department" },{key: 'Seniority', label: "Seniority" }];

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
                rows={JobTitles}
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
      controlId: "JobTitle",
      label: "JobTitle ",
      value: JobTitle,
      onChange: setJobTitle,
    },
    {
      controlId: "Department",
      label: "Department",
      value: Department,
      onChange: setDepartment,
    },
    {
      controlId: "Seniority",
      label: "Seniority",
      value: Seniority,
      onChange: setSeniority,
    },
  ]}
  handleSubmit={handleSubmit}
  mode={selectedJobTitle ? "edit" : "add"}
  selectedEntity={selectedJobTitle} // Check if selectedJobTitle is correctly passed here
  updateEntity={UpdateJobTitle}
  addEntity={AddJobTitle}
/>



    </div>
  );
};

export default JobTitlesPage;