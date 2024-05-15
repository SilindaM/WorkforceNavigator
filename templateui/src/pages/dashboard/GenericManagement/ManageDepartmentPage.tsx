import React, { useEffect, useState } from "react";
import { Grid, Segment, Container, Header, GridColumn } from "semantic-ui-react";
import DepartmentsPage from "./DepartmentsPage";
import DepartmentDetails from "./DepartmentDetails";

const ManageDepartmentPage = () => {
  const [selectedDepartment, setSelectedDepartment] = useState<number | null>(null);

  const handleDepartmentSelect = (departmentId: number |null) => {
    console.log("Selected Id ", departmentId)
    setSelectedDepartment(departmentId);
  };
  useEffect(() => {
    return () => {
        setSelectedDepartment(null);
    };
  }, []);
  
  return (
    <Container fluid className="pageTemplate3">
      <Grid columns={2}>
        <GridColumn width={8}>
          <Segment raised>
            <Header as="h2" textAlign="center">
               DEPARTMENTS
            </Header>
            <DepartmentsPage selectDepartment={handleDepartmentSelect}/>
          </Segment>
        </GridColumn>

        <GridColumn width={8}>
          <Segment raised>
            <Header as="h2" textAlign="center">
                DEPARTMENT DETAILS
            </Header>
              {selectedDepartment && <DepartmentDetails selectedDepartment={selectedDepartment}/>}
          </Segment>
        </GridColumn>
      </Grid>
    </Container>
  );
};

export default ManageDepartmentPage;