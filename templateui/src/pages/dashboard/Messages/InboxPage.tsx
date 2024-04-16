import React, { useEffect, useState } from 'react';
import axiosInstance from '../../../utils/axiosInstance';
import { MY_MESSAGE_URL } from '../../../utils/globalConfig';
import { toast } from 'react-hot-toast';
import Spinner from '../../../components/general/Spinner';
import moment from 'moment';
import { MdInput, MdOutput } from 'react-icons/md';
import useAuth from '../../../hooks/useAuth.hook';
import { IMessageDto } from '../../../types/message.type';
import { Table } from 'semantic-ui-react';

const InboxPage = () => {
  const { user } = useAuth();
  const [messages, setMessages] = useState<IMessageDto[]>([]);
  const [loading, setLoading] = useState<boolean>(false);

  const getMyMessages = async () => {
    try {
      setLoading(true);
      const response = await axiosInstance.get<IMessageDto[]>(MY_MESSAGE_URL);
      const { data } = response;
      setMessages(data);
      setLoading(false);
    } catch (error) {
      toast.error('An Error happened. Please Contact admins');
      setLoading(false);
    }
  };

  useEffect(() => {
    getMyMessages();
  }, []);

  if (loading) {
    return (
      <div className='w-full'>
        <Spinner />
      </div>
    );
  }

  return (
    <div>
      <div className='pageTemplate3 items-stretch'>
        <Table celled>
          <Table.Header>
            <Table.Row>
              <Table.HeaderCell>Date</Table.HeaderCell>
              <Table.HeaderCell>Type</Table.HeaderCell>
              <Table.HeaderCell>Text</Table.HeaderCell>
              <Table.HeaderCell>Sender</Table.HeaderCell>
              <Table.HeaderCell>Receiver</Table.HeaderCell>
            </Table.Row>
          </Table.Header>
          <tbody>
            {messages.map((item) => (
              <tr key={item.id}>
                <Table.Cell>{moment(item.createdAt).fromNow()}</Table.Cell>
                <Table.Cell>
                  {item.senderUserName === user?.userName ? (
                    <MdOutput className='text-2xl text-purple-500' />
                  ) : (
                    <MdInput className='text-2xl text-green-500' />
                  )}
                </Table.Cell>
                <Table.Cell>{item.text}</Table.Cell>
                <Table.Cell>{item.senderUserName}</Table.Cell>
                <Table.Cell>{item.receiverUserName}</Table.Cell>
              </tr>
            ))}
          </tbody>
        </Table>
      </div>
    </div>
  );
};

export default InboxPage;
