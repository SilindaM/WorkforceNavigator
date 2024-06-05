import React, { useEffect, useState } from "react";
import Button from "react-bootstrap/Button";
import Form from "react-bootstrap/Form";
import Modal from "react-bootstrap/Modal";
import { useForm } from "react-hook-form";

interface FormField {
  controlId: string;
  label: string;
  value: any;
  onChange: (value: any) => void;
  disabled?: boolean;
  options?: { value: any; label: string }[];
}

interface IProps {
  isOpen: boolean;
  closeModal: () => void;
  title: string; 
  formFields: FormField[];
  handleSubmit: () => void;
  selectedEntity?: any;
  updateEntity?: (id: number, data: any) => Promise<void>;
  addEntity?: (data: any) => Promise<void>;
  mode: "edit" | "add";
  initialValues?: { [key: string]: any } | null;
}

const GenericModal = ({
  isOpen,
  closeModal,
  title,
  formFields,
  handleSubmit,
  selectedEntity,
  updateEntity,
  addEntity,
  mode,
  initialValues
}: IProps) => {
  const { register, setValue, control } = useForm();

  const handleSave = async () => {
    if (mode === "edit" && updateEntity && selectedEntity) {
      // Create a clean updateData object with values from formFields
      const updateData: { [key: string]: any } = {};
      formFields.forEach((field) => {
        updateData[field.controlId] = field.value;
      });
      updateEntity(selectedEntity.id, updateData);
    } 

    else if (mode === "add" && addEntity)
       {
      // Create a clean newData object with values from formFields
      const newData: { [key: string]: any } = {};
      formFields.forEach((field) => {
        newData[field.controlId] = field.value;
      });
      await addEntity(newData);
    }
    closeModal(); // Close modal after saving
  };

  const initialFormData: { [key: string]: any } = {};
  formFields.forEach((field) => {
    initialFormData[field.controlId] = "";
  });

  useEffect(() => {
    console.log("selectedEntity:", selectedEntity);
    console.log("initialValues:", initialValues);
  
    if (mode === "edit" && selectedEntity) {
      // Register fields dynamically and set initial values
      formFields.forEach((field) => {
        register(field.controlId, { required: true }); // Adjust validation rules as needed
  
        // Check if the field exists in the selectedEntity
        if (selectedEntity.hasOwnProperty(field.controlId)) {
          // Set initial value directly from selectedEntity
          setValue(field.controlId, selectedEntity[field.controlId], {
            shouldValidate: true,
          });
        }
      });
    } else if (mode === "edit" && initialValues) {
      // If initial values are provided but selectedEntity is not present (perhaps when creating a new entity)
      formFields.forEach((field) => {
        setValue(field.controlId, initialValues[field.controlId]);
      });
    } else {
      // If not in edit mode and no initial values provided, reset all form fields to their initial state
      formFields.forEach((field) => {
        setValue(field.controlId, "");
      });
    }
  }, [isOpen, selectedEntity, mode, formFields, register, setValue, initialValues]);
  

  return (
    <>
      <Modal show={isOpen} onHide={closeModal} centered>
        <Modal.Header closeButton>
          <Modal.Title>{title}</Modal.Title>
        </Modal.Header>
        <Modal.Body className="d-flex justify-content-center align-items-center">
          <Form>
            {formFields.map((field, index) => (
              <Form.Group
                key={index}
                className="mb-3"
                controlId={field.controlId}
              >
                {field.options ? ( // Check if options exist
                  <Form.Select
                    defaultValue={field.value}
                    onChange={(e) => field.onChange(e.target.value)}
                  >
                    {field.options.map((option, index) => (
                      <option key={index} value={option.value}>
                        {option.label}
                      </option>
                    ))}
                  </Form.Select>
                ) : (
                  <Form.Control
                  type="text"
                  placeholder={field.label}
                  defaultValue={mode === 'edit' ? initialValues?.[field.controlId] : field.value}
                  onChange={(e) => field.onChange(e.target.value)}
                />                             
                )}
              </Form.Group>
            ))}
          </Form>
        </Modal.Body>
        <Modal.Footer className="justify-content-center">
          <Button variant="secondary" onClick={closeModal}>
            Close
          </Button>
          <Button variant="primary" onClick={handleSave}>
            Save Changes
          </Button>
        </Modal.Footer>
      </Modal>
    </>
  );
};

export default GenericModal;