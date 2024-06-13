import React, { useEffect, useState } from "react";
import { Button, Grid } from "@mui/material";
import AddIcon from "@mui/icons-material/Add";
import { useForm } from "react-hook-form";
import { GridColumn, Segment, Header, Container } from "semantic-ui-react";
import { GenericCrudOperations } from "../../../../components/general/GenericCrudOperations";
import TableField from "../../../../components/general/TableField";
import GenericModal from "../GenericModal";
import { IProjectDto, IUpdateProjectDto } from "../../../../types/Project.type";
import { ALL_PROJECTS, DELETE_PROJECT_URL, NEW_PROJECT_URL, UPDATE_PROJECT_URL } from "../../../../utils/globalConfig";

interface IProps {
  selectedProjectId: (projectId: number | null) => void;
}

const ProjectsPage = ({ selectedProjectId }: IProps) => {
  const { control } = useForm();
  const [loading, setLoading] = useState<boolean>(false);
  const [isOpen, setIsOpen] = useState(false);
  const [projects, setProjects] = useState<IProjectDto[]>([]);
  const [selectedProject, setSelectedProject] = useState<IProjectDto | null>(null);
  const [projectName, setProjectName] = useState<string | null>(null);
  const [description, setDescription] = useState<string>("");

  const handleOpenModal = () => {
    setIsOpen(true);
    setSelectedProject(null); // Reset selectedProject to null
    setProjectName(null); // Reset form fields to empty
    setDescription("");
  };

  const handleCloseModal = () => {
    setIsOpen(false);
  };

  const getProjects = async () => {
    await GenericCrudOperations.getAll(
      ALL_PROJECTS,
      setProjects,
      setLoading
    );
  };

  const AddProject = async (newData: IProjectDto) => {
    await GenericCrudOperations.add(NEW_PROJECT_URL, newData, setLoading);
    getProjects();
  };

  const handleRowClick = (project: IProjectDto) => {
    selectedProjectId(project.id);
    setSelectedProject(project);
  };

  const UpdateProject = async (
    id: number,
    updatedData: IUpdateProjectDto
  ) => {
    await GenericCrudOperations.update(
      UPDATE_PROJECT_URL,
      id,
      updatedData,
      setLoading
    );
  };

  const DeleteProject = async (id: number) => {
    await GenericCrudOperations.remove(DELETE_PROJECT_URL, id, setLoading);
  };

  const handleEdit = (updatedData: IProjectDto) => {
    setSelectedProject(updatedData);
    setProjectName(updatedData.projectName || "");
    setDescription(updatedData.clientName || "");
    handleOpenModal();
  };

  const handleDelete = (id: number) => {
    DeleteProject(id);
  };

  const handleSubmit = () => {
    handleCloseModal();
  };

  useEffect(() => {
    getProjects();
  }, []);

  const columns = [
    { key: "projectName", label: "Project Name" },
    { key: "description", label: "Description" },
    { key: "clientName", label: "Client Name" },
    { key: "teamName", label: "Team Name" },
    { key: "startDate", label: "Start Date" },
    { key: "endDate", label: "End Date" },
  ];

  const initialValues = {
    id: selectedProject?.id || null,
    projectName: selectedProject?.projectName || "",
    description: selectedProject?.description || "",
    clientName: selectedProject?.clientName || "",
    teamName: selectedProject?.teamName || "",
    startDate: selectedProject?.startDate || null,
    endDate: selectedProject?.endDate || null,
  };

  return (
    <div>
      <Container fluid className="pageTemplate3">
        <Grid columns={2}>
          <GridColumn width={16}>
            <Segment raised>
              <Header as="h2" textAlign="center">
                <Button
                  variant="outlined"
                  sx={{ height: "40px" }}
                  startIcon={<AddIcon />}
                  onClick={() => handleOpenModal()}
                >
                  New
                </Button>
              </Header>
              <TableField
                columns={columns}
                rows={projects}
                onEdit={handleEdit}
                onDelete={handleDelete}
                onRowClick={handleRowClick}
                showActions={true}
              />
            </Segment>
          </GridColumn>
        </Grid>
      </Container>

      <GenericModal
        isOpen={isOpen}
        closeModal={handleCloseModal}
        title="Add"
        formFields={[
          {
            controlId: "projectName",
            label: "Project Name",
            value: projectName,
            onChange: setProjectName,
          },
          {
            controlId: "description",
            label: "Description",
            value: description,
            onChange: setDescription,
          },
          {
            controlId: "startDate",
            label: "Start Date",
            value: initialValues.startDate,
            onChange: () => {}, // Add the onChange handler if needed
          },
          {
            controlId: "endDate",
            label: "End Date",
            value: initialValues.endDate,
            onChange: () => {}, // Add the onChange handler if needed
          },
        ]}
        handleSubmit={handleSubmit}
        mode={selectedProject ? "edit" : "add"}
        selectedEntity={selectedProject}
        updateEntity={UpdateProject}
        addEntity={AddProject}
        initialValues={initialValues}
      />
    </div>
  );
};
export default ProjectsPage;