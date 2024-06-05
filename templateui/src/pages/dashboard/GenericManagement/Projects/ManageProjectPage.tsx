import React, { useState } from "react";
import { Grid, Segment, Container, Header, GridColumn } from "semantic-ui-react";
import ProjectsPage from "./ProjectsPage";
import ProjectDetails from "./ProjectDetailsPage";

const ManageProjectPage = () => {
  const [selectedProjectId, setSelectedProjectId] = useState<number | null>(null);

  const handleProjectSelect = (projectId: number | null) => {
    setSelectedProjectId(projectId);
  };

  return (
    <Container fluid className="pageTemplate3">
      <Grid columns={2}>
        <GridColumn width={8}>
          <Segment raised>
            <Header as="h2" textAlign="center">
              PROJECTS
            </Header>
            <ProjectsPage selectedProjectId={handleProjectSelect} />
          </Segment>
        </GridColumn>
        <GridColumn width={8}>
          <Segment raised>
            <Header as="h2" textAlign="center">
              PROJECT DETAILS
            </Header>
            {selectedProjectId && <ProjectDetails selectedProject={selectedProjectId} />}
          </Segment>
        </GridColumn>
      </Grid>
    </Container>
  );
};

export default ManageProjectPage;
