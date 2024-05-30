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
  selectedTimesheetDate: (timesheetDate: Date) => void;
}

const TimesheetPage = ({ selectedTimesheetDate }: IProps) => {
  const [timesheets, setTimesheets] = useState<TimesheetDto[]>([]);
  const [selectedTimesheet, setSelectedTimesheet] = useState<TimesheetDto | null>(null);
  const [isOpen, setIsOpen] = useState(false);
  const [loading, setLoading] = useState<boolean>(false);

  const handleOpenModal = () => {
    setIsOpen(true);
  };

  const handleCloseModal = () => {
    setIsOpen(false);
  };

  const getWeeklyTimesheet = async (id: number) => {
    setLoading(true);
    await GenericCrudOperations.getDetailed(MY_TIMESHEETS, {id}, setTimesheets, setLoading);
    setLoading(false);
  };

  const deleteTimesheet = async (id: number) => {
    setLoading(true);
    await GenericCrudOperations.remove(DELETE_DEPARTMENT_URL, id, setLoading);
    setLoading(false);
  };

  const handleEdit = (updatedData: TimesheetDto) => {
    setSelectedTimesheet(updatedData);
    handleOpenModal();
  };

  const handleRowClick = (timesheet: Date) => {
    const dateObject = new Date(timesheet);
    selectedTimesheetDate(dateObject);
    console.log("F",timesheet)
  };
  
 /* const handleRowClicdk = (timesheet: any) => {
    const dateObject = new Date(timesheet.date);
    const year = dateObject.getFullYear();
    const month = String(dateObject.getMonth() + 1).padStart(2, '0');
    const day = String(dateObject.getDate()).padStart(2, '0');
    const dateWithoutTime = `${year}-${month}-${day}`;
    selectedTimesheetDate(dateWithoutTime);
    console.log("Date without time:", dateWithoutTime);
  };
  */

  const handleDelete = async (id: number) => {
    await deleteTimesheet(id);
    getWeeklyTimesheet(0); // Refresh the timesheets after deletion
  };

  const columns = [
    { key: "dayName", label: "Day" },
    { key: "date", label: "Date" },
    { key: "totalHours", label: "Total Hours" },
    { key: "projectNames",label:"Project Names"}
  ];

  useEffect(() => {
    getWeeklyTimesheet(0);
    //setTimesheets
  }, [undefined]);

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
                New Timesheet Entry
              </Button>
            </Header>
            <TableField
              rows={timesheets}
              columns={columns}
              onEdit={handleEdit}
              onDelete={handleDelete}
              onRowClick={handleRowClick}
            />
          </Segment>
        </GridColumn>
      </Grid>
    </Container>
  );
};

export default TimesheetPage;