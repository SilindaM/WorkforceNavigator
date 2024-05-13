import React from "react";
import { Table, ButtonGroup } from "react-bootstrap";
import { Button, TableHead } from "@mui/material";
import EditIcon from '@mui/icons-material/Edit';
import DeleteOutlineIcon from '@mui/icons-material/DeleteOutline';

interface TableFieldProps<T> {
  rows: T[];
  columns: { key: string; label: string }[];
  onEdit: (data:any) => void;
  onDelete: (id: number) => void;
  options?: { value: any; label: string }[]; 
}

const TableField = <T,>({
  rows,
  columns,
  onEdit,
  onDelete
}: TableFieldProps<T>) => {
  return (
    <div className="px-4 my-2 w-full">
      <Table striped bordered hover>
        <thead>
          <tr>
            {columns.map((column) => (
              <th key={column.key}>{column.label}</th>
            ))}
            <th>Actions</th>
          </tr>
        </thead>
        <tbody>
          {rows.map((row: any, index) => (
            <tr key={index}>
              {columns.map((column) => (
                <td key={column.key}>{row[column.key]}</td>
              ))}
              <td>
              <ButtonGroup>
                    <Button
                      variant="outlined" color="warning"
                      sx={{ height: '30px' ,width:'50%'}} // Adjust the height as needed
                      style={{ fontSize: 'medium' }}
                      startIcon={<EditIcon />}
                      onClick={() => onEdit(row)} // Pass the row data to the edit function
                    >
                      Edit
                    </Button>
                    <Button
                      variant="outlined" color="error"
                      sx={{ height: '30px' }} // Adjust the height as needed
                      style={{ fontSize: 'medium' }}
                      startIcon={<DeleteOutlineIcon />}
                      onClick={()=>onDelete(row.id)} // Implement delete functionality if needed
                    >
                      Delete
                    </Button>
                  </ButtonGroup>
              </td>
            </tr>
          ))}
        </tbody>
      </Table>
    </div>
  );
};

export default TableField;
