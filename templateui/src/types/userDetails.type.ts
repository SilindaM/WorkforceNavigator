export interface UserDetailsDto {
    id: string;
    firstName: string;
    lastName: string;
    email: string;
    username: string;
    roles: string[];
    gender?: string;
    jobTitle?: string;
    salary?: number;
    lineManager?: string;
    department: string;
    seniority: string;
    joiningDate: Date;
}

