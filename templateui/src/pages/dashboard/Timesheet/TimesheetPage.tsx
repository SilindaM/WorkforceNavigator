import React from 'react'
import { Container, Grid, GridColumn, Segment, Header, Button } from 'semantic-ui-react'
import TableField from '../../../components/general/TableField'

const TimesheetPage = () => {
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
            onRowClick={handleRowClick}/>
        </Segment>
      </GridColumn>
    </Grid>
  </Container>
  )
}

export default TimesheetPage