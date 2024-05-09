import toast from "react-hot-toast";
import axiosInstance from "../../utils/axiosInstance";

export const GenericCrudOperations = {
  async getAll(resourceUrl: string, setEntities: (data: any) => void, setLoading: (loading: boolean) => void) {
    try {
      setLoading(true);
      const response = await axiosInstance.get(resourceUrl);
      const { data } = response;
      setEntities(data);
      setLoading(false);
    } catch (error) {
      toast.error("Error Occurred");
      setLoading(false);
    }
  },

  async add(resourceUrl: string, newData: any, setLoading: (loading: boolean) => void) {
    try {
      setLoading(true);
      const response = await axiosInstance.post(resourceUrl, newData);
      const { data } = response;
      toast.success("Added Successfully");
      setLoading(false);
      return data;
    } catch (error) {
      toast.error("Error Occurred");
      setLoading(false);
      throw error;
    }
  },

  async update(resourceUrl: string, id: any, updatedData: any, setLoading: (loading: boolean) => void) {
    try {
      setLoading(true);
      const response = await axiosInstance.post(`${resourceUrl}?id=${id}`, updatedData);
      const { data } = response;
      toast.success("Updated Successfully");
      setLoading(false);
      return data;
    } catch (error) {
      toast.error("Error Occurred");
      setLoading(false);
      throw error;
    }
  },

  async remove(resourceUrl: string, id: any, setLoading: (loading: boolean) => void) {
    try {
      setLoading(true);
      // Implement delete request
      setLoading(false);
      toast.success("Deleted Successfully");
    } catch (error) {
      toast.error("Error Occurred");
      setLoading(false);
      throw error;
    }
  },

  
}