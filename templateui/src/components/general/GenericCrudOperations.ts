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

  async update(resourceUrl: any, id: number, updatedData: any, setLoading: (loading: boolean) => void) {
    try {
      // Log the id and updatedData just before making the API call
      console.log("Get Details",resourceUrl, id, updatedData);
  
      setLoading(true);
      const response = await axiosInstance.post(`${resourceUrl}?id=${id}`, updatedData);
      const { data } = response;
      console.log("fika la")
      toast.success("Updated Successfully");
      setLoading(false);
      return data;
    } catch (error) {
      toast.error("Error Occurred Here");
      setLoading(false);
      throw error;
    }
  },
  
  async remove(resourceUrl: any, id: number, setLoading: (loading: boolean) => void) {
    try {
      setLoading(true);
      const response = await axiosInstance.delete(`${resourceUrl}?id=${id}`);
      const {data} =response;
      setLoading(false);
      toast.success("Deleted Successfully");
    } catch (error) {
      toast.error("Error Occurred");
      setLoading(false);
      throw error;
    }
  },

  
}