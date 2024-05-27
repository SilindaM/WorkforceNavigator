import React, { useEffect, useState } from "react";
import {
  Container,
  Grid,
  GridColumn,
  Segment,
  Header,
  Button,
} from "semantic-ui-react";
import TableField from "../../../components/general/TableField";
import AddIcon from "@mui/icons-material/Add";
import { GenericCrudOperations } from "../../../components/general/GenericCrudOperations";
import { DELETE_DEPARTMENT_URL, MY_TIMESHEETS } from "../../../utils/globalConfig";

interface IProps {
  selectTimesheet: (timesheetId: number | null) => void;
}

const TimesheetPage = ({ selectTimesheet }: IProps) => {
  const [timesheets, setTimesheet] = useState<TimesheetDetail[]>([]);
  const [selectedTimesheet, setSelectedTimesheet] = useState<TimesheetDetail>();
  const [isOpen, setIsOpen] = useState(false);
  const [loading, setLoading] = useState<boolean>(false);

  const handleOpenModal = () => {
    setIsOpen(true);
  };

  const handleCloseModal = () => {
    setIsOpen(false);
  };

  const getWeeklyTimesheet = async (id: number) => {
    await GenericCrudOperations.getDetails(
      MY_TIMESHEETS,
      id,
      setTimesheet,
      setLoading
    );
  };

  const deleteDepartment = async (id: number) => {
    await GenericCrudOperations.remove(DELETE_DEPARTMENT_URL, id, setLoading);
  };

  const handleEdit = (updatedData: TimesheetDetail) => {
    console.log("Editing:", updatedData); // Check if this logs the correct data
    setSelectedTimesheet(updatedData);
    handleOpenModal();
  };

  const handleRowClick = (timesheetId: number | null) => {
    selectTimesheet(timesheetId);
  };

  const handleDelete = (id: number) => {
    console.log("Get Id", id);
    deleteDepartment(id);
    console.log("Received ", id);
  };

  const columns = [
    { key: "Day", label: "Day" },
    { key: "Date", label: "Date" },
    { key: "Total Hours", label: "Total Hours" },
    { key: "Project Name", label: "Projects Worked On" },
  ];

  useEffect(() => {
    getWeeklyTimesheet(0);
  }, []); // Empty dependency array to run only once on mount

  return (
    <Container fluid className="pageTemplate3">
      <Grid columns={2}>
        <GridColumn width={16}>
          <Segment raised>
            <Header as="h2" textAlign="center">
              <Button
                variant="outlined"
                sx={{ height: "40px" }}
                startIcon={<AddIcon />}
                onClick={handleOpenModal}
              >
                New Leave Request
              </Button>
            </Header>
            <TableField
              rows={timesheets}
              columns={columns}
              onEdit={handleEdit}
              onDelete={handleDelete}
              onRowClick={handleRowClick}
               // Pass loading state to TableField if it supports it
            />
          </Segment>
        </GridColumn>
      </Grid>
    </Container>
  );
};

export default TimesheetPage;
