import { createQuery } from '@/data/index';

export const useProjectsQuery = () => {
  const { data: projects, isLoading } = createQuery(
    ['home-projects'],
    () => loadProjects()
  );
  
  return { projects, isLoading };
}

export const useGrantsQuery = () => {
  const { data: grants, isLoading } = createQuery(
    ['home-grants'],
    () => loadGrants()
  );

  return { grants, isLoading };
}

async function loadGrants() {
  const grants = await import('./grants.json');
  return <Grant[]>grants.default;
}

async function loadProjects() {
  const grants = await import('./projects.json');
  return <Project[]>grants.default;
}

export interface Project {
  name: string;
  slug: string;
  city: string;
  budgetType: BudgetType;
  budgetAmountFrom: number;
  budgetAmountTo?: number;
  ngoName: string;
}

export interface Grant {
  name: string;
  slug: string;
  city: string;
  budgetFrom: number;
  budgetTo: number;
  companyName: string;
}

export enum BudgetType {
  Money = 'Money',
  People = 'People',
}
