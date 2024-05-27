import React, { useState } from "react";
import { Grid, Segment, Container, Header, GridColumn } from "semantic-ui-react";
import TimesheetPage from "./TimesheetPage";
import TimesheetDetails from "./TimesheetDetails";

const ManageTimesheetPage = () => {
  const [selectedTimesheetId, setSelectedTimesheetId] = useState<number | null>(null);

  const handleDepartmentSelect = (timesheetId: number | null) => {
    setSelectedTimesheetId(timesheetId);
  };

  return (
    <Container fluid className="pageTemplate3">
      <Grid columns={2}>
        <GridColumn width={10}>
          <Segment raised>
            <Header as="h2" textAlign="center">
              WEEKLY TIMESHEET
            </Header>
            <TimesheetPage selectTimesheet={handleDepartmentSelect}/>
          </Segment>
        </GridColumn>

        <GridColumn width={6}>
          <Segment raised>
            <Header as="h2" textAlign="center">
              TIMESHEET DETAILS
            </Header>
            {/* Pass selectedDepartmentId directly */}
            {selectedTimesheetId && <TimesheetDetails selectedDepartmentId={selectedTimesheetId}/>}
          </Segment>
        </GridColumn>
      </Grid>
    </Container>
  );
};

export default ManageTimesheetPage;