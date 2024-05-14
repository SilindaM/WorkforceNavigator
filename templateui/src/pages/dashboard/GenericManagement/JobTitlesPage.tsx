import React, { useEffect, useState } from "react";
import { Button } from "@mui/material";
import AddIcon from "@mui/icons-material/Add";
import { useForm } from "react-hook-form";
import axiosInstance from "../../../utils/axiosInstance";
import toast from "react-hot-toast";
import {
  Container,
  Grid,
  GridColumn,
  Header,
  Segment,
} from "semantic-ui-react";
import TableField from "../../../components/general/TableField";
import GenericModal from "./GenericModal";
import { GenericCrudOperations } from "../../../components/general/GenericCrudOperations";
import {
  ICreateJobTitleDto,
  IJobTitleDto,
  IUpdateJobTitleDto,
} from "../../../types/JobTitle.type";
import {
  ALL_DEPARTMENTS,
  ALL_JOB_TITLES,
  DELETE_JOBTITLE_URL,
  NEW_JOBTITLE_URL,
  UPDATE_JOBTITLE_URL,
} from "../../../utils/globalConfig";
import { IDepartmentDto } from "../../../types/Department.type";
import { Seniority } from "../../../types/auth.type";

const JobTitlesPage = () => {
  const { control } = useForm();
  const [loading, setLoading] = useState<boolean>(false);
  const [isOpen, setIsOpen] = useState(false);
  const [JobTitles, setJobTitles] = useState<IJobTitleDto[]>([]);
  const [selectedJobTitle, setSelectedJobTitle] = useState<IJobTitleDto | null>(
    null
  );
  const [JobTitle, setJobTitle] = useState<string>("");
  const [Description, setDescription] = useState<string>("");
  const [DepartmentId, setDepartmentId] = useState<number>();
  const [Departments, setSelectedDepartment] = useState<IDepartmentDto[]>([]);
  const [seniority, setSeniority] = useState<Seniority>(); // Initialize as an empty array

  const handleOpenModal = () => {
    setIsOpen(true);
  };

  const handleCloseModal = () => {
    setIsOpen(false);
  };

  const seniorityOptions = [
    { value: "junior", label: "Junior" },
    { value: "mid", label: "Mid" },
    { value: "senior", label: "Senior" },
    { value: "lead", label: "Lead" },
  ];

  const getJobTitles = async () => {
    await GenericCrudOperations.getAll(
      ALL_JOB_TITLES,
      setJobTitles,
      setLoading
    );
  };

  const getDepartments = async () => {
    await GenericCrudOperations.getAll(
      ALL_DEPARTMENTS,
      setSelectedDepartment,
      setLoading
    );
  };

  const AddJobTitle = async (newData: ICreateJobTitleDto) => {
    console.log("New Job Title Data:", newData);
    await GenericCrudOperations.add(NEW_JOBTITLE_URL, newData, setLoading);
    getJobTitles();
  };

  const UpdateJobTitle = async (
    id: number,
    updatedData: IUpdateJobTitleDto
  ) => {
    await GenericCrudOperations.update(
      UPDATE_JOBTITLE_URL,
      id,
      updatedData,
      setLoading
    );
  };

  const DeleteJobTitle = async (id: number) => {
    await GenericCrudOperations.remove(DELETE_JOBTITLE_URL, id, setLoading);
  };

  const handleEdit = (updatedData: IJobTitleDto) => {
    setSelectedJobTitle(updatedData);
    handleOpenModal();
  };

  const handleDelete = (id: number) => {
    DeleteJobTitle(id);
  };

  const handleSubmit = () => {
    handleCloseModal();
  };

  const handleDepartmentChange = (selectedDepartmentId: number) => {
    setDepartmentId(selectedDepartmentId);
    console.log("Check Id " + selectedDepartmentId);
  };
  
  useEffect(() => {
    getJobTitles();
    getDepartments();
  }, []);

  const columns = [
    { key: "JobTitle", label: "JobTitle" },
    { key: "Department", label: "Department" },
    { key: "Seniority", label: "Seniority" },
  ];

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
        title=""
        formFields={[
          {
            controlId: "JobTitle",
            label: "JobTitle ",
            value: JobTitle,
            onChange: setJobTitle,
          },
          {
            controlId: "Description",
            label: "Description ",
            value: Description,
            onChange: setDescription,
          },
          {
            controlId: "Department",
            label: "Department",
            onChange: handleDepartmentChange,
            options: Departments
              ? Departments.map((department) => ({
                  value: department.id,
                  label: department.DepartmentName,
                }))
              : [],
            value: DepartmentId, // Corrected here
          },
          {
            controlId: "Seniority",
            label: "Seniority",
            value: seniority,
            options: seniorityOptions,
            onChange: setSeniority,
          },
        ]}
        handleSubmit={handleSubmit}
        mode={selectedJobTitle ? "edit" : "add"}
        selectedEntity={selectedJobTitle}
        updateEntity={UpdateJobTitle}
        addEntity={AddJobTitle}
      />
    </div>
  );
};

export default JobTitlesPage;
