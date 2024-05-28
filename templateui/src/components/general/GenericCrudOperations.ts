import toast from "react-hot-toast";
import axiosInstance from "../../utils/axiosInstance";

export const GenericCrudOperations = {
  async getAll(resourceUrl: string, setEntities: (data: any) => void, setLoading: (loading: boolean) => void) {
    try {
      setLoading(true);
      console.log("Testing "+ setEntities);
      const response = await axiosInstance.get(resourceUrl);
      const { data } = response;
      setEntities(data);
      console.log("DAta "+ data);
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

  async update(resourceUrl: any, id: any, updatedData: any, setLoading: (loading: boolean) => void) {
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

  async getDetails(resourceUrl: string, id: any, setEntity: (data: any) => void, setLoading: (loading: boolean) => void) {
    try {
      setLoading(true);
      console.log("Endpoint URL:", `${resourceUrl}/${id}`); // Add this line to check the formed URL
      const response = await axiosInstance.get(`${resourceUrl}/${id}`);
      console.log("Response:", response); // Add this line to log the response object
      const { data } = response;
      console.log("Data:", data); // Add this line to log the data extracted from the response
      setEntity(data);
      setLoading(false);
    } catch (error) {
      console.error("Error:", error); // Add this line to log any errors
      toast.error("Error Occurred");
      setLoading(false);
    }
  },  

  async getDetailed(resourceUrl: string, queryParams: any, setEntity: (data: any) => void, setLoading: (loading: boolean) => void) {
    try {
      setLoading(true);
      const response = await axiosInstance.get(resourceUrl, { params: queryParams });
      const { data } = response;
      setEntity(data);
      setLoading(false);
    } catch (error) {
      toast.error("Error Occurred");
      setLoading(false);
    }
  }
}