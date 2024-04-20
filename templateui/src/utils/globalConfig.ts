import { PATH_PUBLIC, PATH_DASHBOARD } from "../routes/path";

// AUTH
export const HOST_API_KEY = 'https://localhost:7148/api';
export const REGISTER_URL = '/Auth/register';
export const LOGIN_URL = '/Auth/login';
export const ME_URL = '/Auth/me';
export const UPDATE_ROLE_URL = '/Auth/UpdateRoles';

//USERS

export const USERNAMES_LIST_URL = '/Auth/usernames';
export const USERS_LIST_URL = '/Auth/users';

//MESSAGES

export const ALL_MESSAGES_URL = '/Message';
export const CREATE_MESSAGE_URL = '/Message/create';
export const MY_MESSAGE_URL = '/Message/mine';

//LOGS

export const LOGS_URL = '/Logs';
export const MY_LOGS_URL = '/Logs/mine';

// LEAVE ALLOCATION
export const ALL_LEAVE_ALLOCATIONS = 'LeaveAllocation/LeaveAllocations'
export const MY_LEAVE_ALLOCATIONS = '/LeaveAllocation/MyLeaveAllocations'
export const USERNAME_LEAVE_ALLOCATIONS = '/LeaveAllocations/username'
export const LEAVE_ALLOCATION_BYTYPE = '/LeaveAllocation/type'

//LEAVE REQUEST
export const MY_LEAVE_REQUESTS = '/LeaveRequest/MyLeaveRequests'
export const UPDATE_LEAVE_REQUEST_URL = '/LeaveRequest/UpdateLeaveRequest';
export const NEW_LEAVE_REQUEST_URL = '/LeaveRequest/Create';


// Auth Routes
export const PATH_AFTER_REGISTER = PATH_PUBLIC.login;
export const PATH_AFTER_LOGIN = PATH_DASHBOARD.dashboard;
export const PATH_AFTER_LOGOUT = PATH_PUBLIC.home;
